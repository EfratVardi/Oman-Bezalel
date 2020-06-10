using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Dal;


namespace oman_batzalel.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("FindeUser")]
        public IHttpActionResult FindeUser([FromBody] User u)
        {
            return Ok(UserBll.FindUser(u));
        }
    }
}
