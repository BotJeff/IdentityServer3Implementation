using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace IdSrv3.Attributes
{
    public class ConfigRegularExpressionAttribute : RegularExpressionAttribute
    {
        public ConfigRegularExpressionAttribute(string configKeyPattern) : base(ConfigurationManager.AppSettings[configKeyPattern])
        {
            /*
             * This class is used for keeping the regex in the config file,
             * making it possible to change username and password requirements without changing code. 
             */
        }
    }
}