using System;
using System.Security.Cryptography.X509Certificates;
using IdentityManager.Configuration;
using IdentityServer3.Core.Configuration;
using IdSrv3.IdentityManager;
using IdSrv3.MembershipReboot;
using Owin;
using IdentityServer3.Core.Logging;
using Microsoft.Owin;
using Serilog;
using Serilog.Configuration;
using IdSrv3.AppSettings;

[assembly: OwinStartup(typeof(IdSrv3.Startup))]

namespace IdSrv3
{
    //https://localhost:44300/identity/.well-known/openid-configuration
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // IdentityManager
            app.Map("/admin", adminApp =>
            {
                var factory = new IdentityManagerServiceFactory();
                //factory.Configure("IdSrv3");
                factory.Configure(Settings.ConnString);
                adminApp.UseIdentityManager(new IdentityManagerOptions()
                {
                    Factory = factory
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
                            new LoginPageLink{
                                Text = "Register",
                                //Href = "~/localregistration"
                                Href = "localregistration"
                            },
                            new LoginPageLink{
                                Text = "Password Reset",
                                //Href = "~/localregistration"
                                Href = "localpasswordreset"
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