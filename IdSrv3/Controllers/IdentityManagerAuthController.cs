using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using IdSrv3.Extensions;
using IdSrv3.MembershipReboot.UserService;
using IdSrv3.Models;

namespace IdSrv3.Controllers
{
    public class IdentityManagerAuthController : Controller
    {
        // GET: IdentityManagerAuth
        [Route("admin/login")]
        [HttpGet]
        public ActionResult Login()
        {
            return Redirect(AppSettings.Settings.BaseUrl + "admin/login");
        }

        [Route("admin/login")]
        [HttpPost]
        public ActionResult Login(IdentityManagerLoginModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    //Too much logic
                    var userService = UserAccountService.GetCustomUserAccountService();
                    var user = userService.GetByUsername(model.Username);

                    if(user.VerifyPassword(model.Password))
                    {
                        List<Claim> claims = new List<Claim>();
                        foreach(var claim in user.Claims)
                        {
                            claims.Add(new Claim(claim.Type, claim.Value));
                        }
                        var id = new ClaimsIdentity(claims, "Cookies");
                        Request.GetOwinContext().Authentication.SignIn(id);
                        return Redirect(model.ReturnUrl);
                    }
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