using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IdSrv3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdSrv3UnitTest.Models
{
    [TestClass]
    public class LocalRegistrationModelUnitTest
    {
        [TestMethod]
        public void UsernameTest()
        {
            try
            {
                LocalRegistrationModel model = new LocalRegistrationModel();

                model.Username = "CoOLANDRO!";
                var results = new List<ValidationResult>();
                //Assert.IsTrue(Validator.TryValidateProperty(model.Username, new ValidationContext(model, null, null) { MemberName="Username"}, results));
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //[TestMethod]
        //public void UsernameAttributeTest()
        //{
        //    try
        //    {
        //        ValidationAttribute attr = new UniqueUsername();
        //        Assert.IsTrue(attr.IsValid("CoOLANDRO!"));
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
        //[TestMethod]
        //public void UsernameRegexTest()
        //{
        //    try
        //    {
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
    }
}