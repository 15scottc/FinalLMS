using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalLMS.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalLMS.Models;


namespace FinalLMS.Controllers.Tests
{
    [TestClass()]
    public class RegistrationsControllerTests
    {
        [TestMethod()]
        public void RegistrationsControllerTest()
        {
            Registration registration = new Registration
            {
                RegistrationId = 5
                
            };

            Assert.IsInstanceOfType(registration.RegistrationId, typeof(int));
        }
    }
}