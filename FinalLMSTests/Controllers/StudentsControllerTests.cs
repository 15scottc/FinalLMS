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
    public class StudentsControllerTests
    {
        [TestMethod()]
        public void GetStudentsTest()
        {
            Students students = new Students
            {
                StudentId = 1
            };
            Assert.AreEqual(1, students.StudentId);
        }
    }
}