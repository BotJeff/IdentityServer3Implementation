using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdSrv3.Models;
using IdentityServer3.Core;
using IdSrv3.MembershipReboot.UserService;

namespace IdSrv3.Controllers
{
    public class PasswordResetWithKeyController : Controller
    {
        // GET: PasswordResetWithKey
        [Route("identity/passwordresetwithkey")]
        [HttpGet]
        public ActionResult Index(string key)
        {
            return View();
        }

        [Route("identity/passwordresetwithkey")]
        [HttpPost]
        public ActionResult Index(string key, PasswordResetWithKeyModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var userService = UserAccountService.GetCustomUserAccountService();
                    userService.ChangePasswordFromResetKey(key, model.NewPassword);
                    return Redirect("Success");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(key, ex.Message);
                }
            }
            return View();
        }
    }
}