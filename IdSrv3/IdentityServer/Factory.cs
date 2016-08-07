using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer3.Core.Configuration;
using IdentityServer3.EntityFramework;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using IdentityServer3.Core.Services.InMemory;

namespace IdSrv3.MembershipReboot
{
    public class Factory
    {
        public static IdentityServerServiceFactory Configure(string connString)
        {
            var options = new EntityFrameworkServiceOptions
            {
                ConnectionString = connString
            };

            //code below is only used to populate the database with InMemory data, only if the database does not exist or is empty.
            ConfigureClients(Clients.Get(), options);
            ConfigureScopes(Scopes.Get(), options);

            var factory = new IdentityServerServiceFactory();

            factory.RegisterConfigurationServices(options);
            factory.RegisterOperationalServices(options);

            //Configure Users
            var userService = new LocalRegistrationUserService();
            factory.UserService = new Registration<IUserService>(resolver => userService);

            return factory;
        }
        public static void ConfigureClients(IEnumerable<Client> clients, EntityFrameworkServiceOptions options)
        {
            using (var db = new ClientConfigurationDbContext(options.ConnectionString, options.Schema))
            {
                if (!db.Clients.Any())
                {
                    foreach (var c in clients)
                    {
                        var e = c.ToEntity();
                        db.Clients.Add(e);
                    }
                    db.SaveChanges();
                }
            }
        }
        public static void ConfigureScopes(IEnumerable<Scope> scopes, EntityFrameworkServiceOptions options)
        {
            using (var db = new ScopeConfigurationDbContext(options.ConnectionString, options.Schema))
            {
                if (!db.Scopes.Any())
                {
                    foreach (var s in scopes)
                    {
                        var e = s.ToEntity();
                        db.Scopes.Add(e);
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}