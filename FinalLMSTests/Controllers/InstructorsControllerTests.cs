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
    public class InstructorsControllerTests
    {
        [TestMethod()]
        public void GetInstructorsTest()
        {
            Instructors instructor = new Instructors
            {
                InstructorId = 5,
                InstructorFirstname = "Joe",
                InstructorLastname = "Silman"
            };
            Assert.IsTrue(instructor.InstructorId == 5, "Program Advisor");
        }
    }
}