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
    public class CoursesControllerTests
    {
        [TestMethod()]
        public void GetCoursesTest()
        {
            Courses course = new Courses
            {
                CourseId = 1
            };
            Assert.AreEqual(1, course.CourseId);
        }
    }
}