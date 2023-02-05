using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;

namespace TPF.FFTools.Infrastructure.Handler
{
	public static class TokenHandler
	{
		static string secretKey = "Pw55vOlg2u46SfzVdEYa";
		static string tokenIssuer = "TPF";
		static string tokenAudience = "TPF client";

		public static string CreateToken(string username, int userId)
		{
			//Set issued at date
			DateTime issuedAt = DateTime.UtcNow;
			//set the time when it expires
			////DateTime expires = DateTime.UtcNow.AddDays(7000);

			//http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
			var tokenHandler = new JwtSecurityTokenHandler();

			//create a identity and add claims to the user which we want to log in
			ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
			{
				new Claim(ClaimTypes.Name, username),
				new Claim(ClaimTypes.NameIdentifier, userId.ToString())
			});

			var now = DateTime.UtcNow;
			var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secretKey));
			var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);


			var expires = DateTime.Now.AddDays(3650); //10 years token
			//create the jwt
			var token = tokenHandler.CreateJwtSecurityToken(
																issuer: tokenIssuer,
																audience: tokenAudience,
																subject: claimsIdentity,
																notBefore: issuedAt,
																expires: expires,
																signingCredentials: signingCredentials
															);

			var tokenString = tokenHandler.WriteToken(token);

			return tokenString;
		}

		public static ClaimsPrincipal ValidateToken(string token /*, out SecurityToken securityToken*/)
		{
			SecurityToken securityToken = null;

			var now = DateTime.UtcNow;
			var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(secretKey));

			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			TokenValidationParameters validationParameters = new TokenValidationParameters()
			{
				ValidAudience = tokenAudience,
				ValidIssuer = tokenIssuer,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				LifetimeValidator = LifetimeValidator,
				IssuerSigningKey = securityKey
			};

			return handler.ValidateToken(token, validationParameters, out securityToken);
		}

		public static string GetToken(HttpRequestMessage request)
		{
			string token = null;
			IEnumerable<string> authzHeaders;
			if (!request.Headers.TryGetValues("Authorization", out authzHeaders) || authzHeaders.Count() > 1)
			{
				return null;
			}
			var bearerToken = authzHeaders.ElementAt(0);
			token = bearerToken.StartsWith("Bearer ") ? bearerToken.Substring(7) : bearerToken;
			return token;
		}

		private static bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
		{
			if (expires != null)
			{
				if (DateTime.UtcNow < expires) return true;
			}
			return false;
		}
	}
}