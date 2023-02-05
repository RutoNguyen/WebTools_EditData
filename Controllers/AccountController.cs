using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TPF.FFTools.Data;

using TPF.FFTools.Infrastructure.Handler;
using TPF.FFTools.Models;

namespace TPF.FFTools.Controllers
{
    [RoutePrefix("account")]
    public class AccountController : ApiController
    {
            [HttpPost]
            [Route("login")]
            public string Login(LoginViewModel user)
            {
                using (var tpf2003Context = new Tpf2003Entities())
                {
                    var staff = tpf2003Context.staffs.Where(s => s.username == user.UserName && s.password == user.Password)
                                                      .FirstOrDefault();
                    if (staff != null)
                    {
                        var token = TokenHandler.CreateToken(staff.username, staff.staffID);
                        return token;

                        //return request.CreateResponse(HttpStatusCode.OK, token);
                        //return token;
                    }
                    else
                    {
                        return null;
                        //return request.CreateErrorResponse(HttpStatusCode.BadRequest, "Username/password is not correct").ToString();
                        //throw new Exception("Username/password is not correct");
                    }
                }
            }

    }
}
