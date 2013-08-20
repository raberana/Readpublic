using Readpublic.Business;
using Readpublic.Models;
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
        public HttpResponseMessage AddUser(UserSignUpViewModel userParam)
        {
            UserManager userManager = new UserManager();
            HistoryManager historyManager = new HistoryManager();
            try
            {
                var user = new User();
                user.UserName = userParam.UserName;
                user.Password = userParam.Password;
                user.Email = userParam.Email;
                user.FirstName = userParam.FirstName;
                user.MiddleName = userParam.MiddleName;
                user.LastName = userParam.LastName;

                userManager.Create(user);
                var dbUser = userManager.FindUserEmail(user.Email);
                historyManager.AddHistory(new History(dbUser)
                {
                    Activity = Activities.Joined,
                    Description = Helper.GenerateActivityDescription(dbUser, Activities.Joined)
                });
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
