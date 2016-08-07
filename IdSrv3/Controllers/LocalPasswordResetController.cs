using IdSrv3.Models;
using IdSrv3.MembershipReboot;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web.Mvc;
using IdentityServer3.Core;
using IdSrv3.MembershipReboot.Registration;
using IdSrv3.MembershipReboot.UserService;

namespace IdSrv3.Controllers
{
    public class LocalPasswordResetController : Controller
    {
        [Route("identity/localpasswordreset")]
        [HttpGet]
        public ActionResult Index(string signin)
        {
            return View();
        }

        [Route("identity/localpasswordreset")]
        [HttpPost]
        public ActionResult Index(string signin, EmailModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userService = UserAccountService.GetCustomUserAccountService();
                    userService.ResetPassword(model.Email);

                    return View("EmailSentMessage");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View();
        }
    }
}
