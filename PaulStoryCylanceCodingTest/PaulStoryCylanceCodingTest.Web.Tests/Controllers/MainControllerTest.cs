using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaulStoryCylanceCodingTest.Web.Controllers;

namespace PaulStoryCylanceCodingTest.Web.Tests.Controllers
{
    [TestClass]
    public class MainControllerTest
    {
        [TestMethod]
        public void Index()
        {
            using (var controller = new MainController())
            { 
                var result = controller.Index() as ViewResult;
                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public void Products()
        {
            using (var controller = new MainController())
            {
                var result = controller.Products() as ViewResult;
                Assert.IsNotNull(result);
            }
        }
    }
}
