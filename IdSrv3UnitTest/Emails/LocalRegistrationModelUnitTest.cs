using System;
using System.Runtime.Remoting.Contexts;
using IdSrv3.Email;
using IdSrv3.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdSrv3UnitTest.Emails
{
    [TestClass]
    public class UnitTest_RegisteredUserEmailNotification
    {
        [TestMethod]
        public void SendEmail_Test()
        {
            var user = new UserAccount
            {
                Username = "MikeJones",
                Created  = DateTime.Now,
                FirstName = "Mike",
                LastName = "Jones",
            };
            var content = new RegisteredUserEmailContent(user);
            var notifier = new EmailNotification(content);
            notifier.SendMessage();
        }
    }
}
