using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IdSrv3.Email
{
    public class EmailCommon
    {
        private const string templatePath = "IdSrv3.Email.EmailTemplates.{0}.txt";

        public static string LoadTemplate(string name)
        {
            name = string.Format(templatePath, name);

            var assembly = typeof(IEmailContent).Assembly;
            using(var stream = assembly.GetManifestResourceStream(name))
            {
                if(stream == null) return null;
                using(var streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}