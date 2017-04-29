using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace IdSrv3.Attributes
{
    public class ConfigRegularExpressionAttribute : RegularExpressionAttribute
    {
        public ConfigRegularExpressionAttribute(string configKeyPattern)
            : base(ConfigurationManager.AppSettings[configKeyPattern])
        {
            /*
             * This class is used for keeping the regex in the config file,
             * making it possible to change username and password requirements without changing code.
             */
        }
    }
}