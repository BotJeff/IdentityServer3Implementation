using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace IdSrv3.AppSettings
{
    public static class Settings
    {
        public static string ConnString
        {
            get
            {
                try
                {
                    string connString = ConfigurationManager.AppSettings["ConnectionString"];
                    return @ConfigurationManager.ConnectionStrings[connString].ConnectionString;
                }
                catch
                {
                    throw;
                }
            }
        }
        public static string BaseUrl
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["BaseUrl"];
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}