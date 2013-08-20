using Readpublic.Business;
using Readpublic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readpublic.Controllers
{
    public class UserController : ApiController
    {
        [AcceptVerbs("GET", "POST")]
        public HttpResponseMessage AddUser(User user)
        {
            UserManager userManager = new UserManager();
            try
            {
                userManager.Create(user);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, user);
                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        [AcceptVerbs("GET", "POST")]
        public HttpResponseMessage GetUsers()
        {
            UserManager userManager = new UserManager();
            try
            {
                var users = userManager.FindUsers();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, users);
                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
