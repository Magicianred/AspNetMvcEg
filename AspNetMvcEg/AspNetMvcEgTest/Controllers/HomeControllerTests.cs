using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetMvcEg.Controllers;
using System;
using System.Web.Mvc;

namespace AspNetMvcEgTest.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void TestLoadTableData()
        {
            var controller = new HomeController();
            var result = controller.DataTable() as ViewResult;
            Assert.AreEqual("", result.ViewName);
        }
    }
}
