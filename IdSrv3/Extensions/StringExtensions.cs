using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdSrv3.Crypto.IdSrv3Crypto;

namespace IdSrv3.Extensions
{
    public static class StringExtensions
    {
        public static string HashPasswordByYearIterations(this string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("String cannot be null or empty.");
            }

            ICrypto crypto = new DefaultCrypto();
            return crypto.HashPassword(password, DateTime.Now.Year.GetIterationsFromYear());
        }
    }
}