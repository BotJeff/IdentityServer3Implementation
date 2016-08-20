using System;
using System.Security.Cryptography.X509Certificates;
using IdentityManager.Configuration;
using IdentityServer3.Core.Configuration;
using IdSrv3.AppSettings;
using IdSrv3.IdentityManager;
using IdSrv3.MembershipReboot;
using IdSrv3.MembershipReboot.UserService;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(IdSrv3.Startup))]

namespace IdSrv3
{
    //https://localhost:44300/identity/.well-known/openid-configuration
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies",
                LoginPath = new PathString("/Home/Login")  //Creates a login path for IdentityManager
            });

            // IdentityManager
            app.Map("/admin", adminApp =>
            {
                var factory = new IdentityManagerServiceFactory();
                factory.Configure(Settings.ConnString);

                adminApp.UseIdentityManager(new IdentityManagerOptions()
                {
                    Factory = factory,
                    SecurityConfiguration = new HostSecurityConfiguration
                    {//Without this the the management website does not prompt for login.
                     //A custom login page needs to be created.
                        HostAuthenticationType = "Cookies",
                        NameClaimType = "name",
                        RoleClaimType = "role",
                        AdminRoleName = "Admin",
                        RequireSsl = true,
                        ShowLoginButton = false,
                    }
                });
            });

            // IdentityServer3
            app.Map("/identity", idsSrvApp =>
            {
                var idSrvFactory = Factory.Configure(Settings.ConnString);
                idSrvFactory.ConfigureCustomUserService(Settings.ConnString);

                idsSrvApp.UseIdentityServer(new IdentityServerOptions
                {
                    SiteName = "OSCid",
                    SigningCertificate = LoadCertificate(),
                    Factory = idSrvFactory,

                    AuthenticationOptions = new AuthenticationOptions
                    {
                        //IdentityProviders = ConfigureAdditionalIdentityProviders,
                        LoginPageLinks = new LoginPageLink[] {
                            new LoginPageLink
                            {
                                Text = "Register",
                                Href = "registration"
                            },
                            new LoginPageLink{
                                Text = "Password Reset",
                                Href = "requestpasswordreset"
                            }
                        }
                    },

                    EventsOptions = new EventsOptions
                    {
                        RaiseSuccessEvents = true,
                        RaiseErrorEvents = true,
                        RaiseFailureEvents = true,
                        RaiseInformationEvents = true
                    }
                });
            });
        }

        private X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\bin\IdentityServer\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
    }
}