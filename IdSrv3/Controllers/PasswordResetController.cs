using System;
using System.Web.Mvc;
using IdSrv3.MembershipReboot.UserService;
using IdSrv3.Models;
using System.Runtime.Caching;
using IdentityServer3.Core;

namespace IdSrv3.Controllers
{
    public class PasswordResetController : Controller
    {
        [Route("identity/requestpasswordreset")]
        [HttpGet]
        public ActionResult RequestPasswordReset(string signin)
        {
            return View();
        }

        [Route("identity/requestpasswordreset")]
        [HttpPost]
        public ActionResult RequestPasswordReset(string signin, EmailModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var userService = UserAccountService.GetCustomUserAccountService();
                    userService.ResetPassword(model.Email);

                    var user = userService.GetByEmail(model.Email);

                    ObjectCache cache = MemoryCache.Default;
                    cache.Set(user.Username, signin, DateTime.Now.AddHours(4));

                    ViewData.Add("signin", signin);
                    return View("EmailSentMessage");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View();
        }

        [Route("identity/passwordresetwithkey")]
        [HttpGet]
        public ActionResult PasswordResetWithKey(string key)
        {
            return View();
        }

        [Route("identity/passwordresetwithkey")]
        [HttpPost]
        public ActionResult PasswordResetWithKey(string key, PasswordResetWithKeyModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var userService = UserAccountService.GetCustomUserAccountService();
                    var user = userService.GetByVerificationKey(key);

                    ObjectCache cache = MemoryCache.Default;
                    string signin = cache[user.Username] as string;

                    if(signin == null)
                        throw new ArgumentNullException("Password reset key expired.");

                    userService.ChangePasswordFromResetKey(key, model.NewPassword);

                    return Redirect("~/identity/"
                                    + Constants.RoutePaths.Login
                                    + "?signin="
                                    + signin);
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View();
        }

        [Route("identity/cancelverification")]
        [HttpGet]
        public ActionResult CancelVerification(string key)
        {
            //TODO: Finish Logic
            try
            {
                var userService = UserAccountService.GetCustomUserAccountService();
                userService.CancelVerification(key);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }
    }
}