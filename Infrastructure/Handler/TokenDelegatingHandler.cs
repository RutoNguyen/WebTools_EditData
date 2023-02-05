using Microsoft.IdentityModel.Tokens;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TPF.FFTools.Infrastructure.Handler
{
	public class TokenDelegatingHandler : DelegatingHandler
	{
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			HttpStatusCode statusCode;
			string token = TokenHandler.GetToken(request);
			//determine whether a jwt exists or not
			if (token == null)
			{
				statusCode = HttpStatusCode.Unauthorized;
				//allow requests with no token - whether a action method needs an authentication can be set with the claimsauthorization attribute
				return base.SendAsync(request, cancellationToken);
			}

			try
			{
				//extract and assign the user of the jwt
				var claimPrinciple = TokenHandler.ValidateToken(token);
				Thread.CurrentPrincipal = claimPrinciple;
				HttpContext.Current.User = claimPrinciple;

				return base.SendAsync(request, cancellationToken);
			}
#pragma warning disable CS0168 // The variable 'e' is declared but never used
			catch (SecurityTokenValidationException e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
			{
				statusCode = HttpStatusCode.Unauthorized;
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
			#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				statusCode = HttpStatusCode.InternalServerError;
			}
			return Task<HttpResponseMessage>.Factory.StartNew(() => new HttpResponseMessage(statusCode) { });
		}
	}
}