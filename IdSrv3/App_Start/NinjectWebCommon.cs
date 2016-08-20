[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(IdSrv3.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(IdSrv3.App_Start.NinjectWebCommon), "Stop")]

namespace IdSrv3.App_Start
{
    using System;
    using System.Web;
    using BrockAllen.MembershipReboot;
    using BrockAllen.MembershipReboot.WebHost;
    using MembershipReboot.CustomDatabases;
    using MembershipReboot.CustomUsers;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            /*
             * Use this area to bind MembershipReboot configuration.
             * J.E.F
             */
            var config = MembershipRebootConfig.Config;
            kernel.Bind<MembershipRebootConfiguration<CustomUser>>().ToConstant(config);
            kernel.Bind<IUserAccountRepository<CustomUser>>().To<CustomUserRepository>().InRequestScope();
            kernel.Bind<CustomDatabase>().ToSelf().InRequestScope();
            kernel.Bind<IUserAccountQuery>().To<CustomUserRepository>().InRequestScope();
            kernel.Bind<AuthenticationService<CustomUser>>().To<SamAuthenticationService<CustomUser>>();
        }        
    }
}
