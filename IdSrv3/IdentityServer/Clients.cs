using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IdentityServer3.Core.Models;

namespace IdSrv3.MembershipReboot
{
    public class Clients
    {
        /*
         * Example 'in memory' clients. Used for testing purposes only.
         */
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "MVC Client",
                    ClientId = "mvc",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:51690/"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "MVC Client2",
                    ClientId = "mvc2",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:50325/"
                    },

                    AllowAccessToAllScopes = true
                }
            };
        }
    }
}