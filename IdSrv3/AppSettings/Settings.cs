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

        public static string EmailSig
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailSig"];
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        public static string FromEmail
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailFrom"];
                }
                catch
                {
                    throw new InvalidOperationException(
                        "Check Web Config : EmailFrom");
                }
            }
        }

        public static string ToEmail
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailTo"];
                }
                catch
                {
                    throw new InvalidOperationException(
                        "Check Web Config : EmailFrom");
                }
            }
        }

        public static string CcEmail
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailCC"];
                }
                catch
                {
                    throw new InvalidOperationException(
                        "Check Web Config : EmailCC");
                }
            }
        }

        public static string BccEmail
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailBCC"];
                }
                catch
                {
                    throw new InvalidOperationException(
                        "Check Web Config : EmailBCC");
                }
            }
        }

        public static string EmailUsername
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailUsername"];
                }
                catch
                {
                    throw new InvalidOperationException(
                        "Check Web Config : EmailUsername");
                }
            }
        }

        public static string EmailPassword
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["EmailPassword"];
                }
                catch
                {
                    throw new InvalidOperationException(
                        "Check Web Config : EmailPassword");
                }
            }
        }
    }
}