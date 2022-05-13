using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalLMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalLMS.Controllers;
using static FinalLMS.Controllers.AssignmentsController;

namespace FinalLMS.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("FakeKeyNotReal1111!");

            User user = new User
            {
                username = "testusername",
                password = "testpassword",
 
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }
    }
}