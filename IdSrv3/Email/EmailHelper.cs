using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IdSrv3.Email
{
    public static class EmailHelper
    {
        private const string templatePath = "IdSrv3.Email.EmailTemplates.{0}.txt";

        public static string LoadTemplate(string name)
        {
            name = string.Format(templatePath, name);
            var assembly = typeof(IEmailContent).Assembly;

            return ReadFileFromAssembly(name, assembly);
        }

        private static string ReadFileFromAssembly(string name, Assembly assembly)
        {
            using(var stream = assembly.GetManifestResourceStream(name))
            {
                if(stream == null) return string.Empty;
                return ReadManifestResourceStream(stream);
            }
        }

        private static string ReadManifestResourceStream(Stream stream)
        {
            using(var streamReader = new StreamReader(stream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}