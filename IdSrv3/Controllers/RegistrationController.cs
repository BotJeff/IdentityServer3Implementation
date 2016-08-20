using IdSrv3.Models;
using IdSrv3.MembershipReboot;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web.Mvc;
using IdentityServer3.Core;
using IdSrv3.MembershipReboot.Registration;

namespace SampleApp.Controllers
{
    public class LocalRegistrationController : Controller
    {
        [Route("identity/localregistration")]
        [HttpGet]
        public ActionResult Index(string signin)
        {
            return View();
        }

        [Route("identity/localregistration")]
        [HttpPost]
        public ActionResult Index(string signin, LocalRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                var registerUser = new RegisterUser();
                registerUser.Register(model);
                
                return Redirect("~/identity/" 
                                + Constants.RoutePaths.Login 
                                + "?signin=" 
                                + signin);
            }
            return View();
        }
    }
}
