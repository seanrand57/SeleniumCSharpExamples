using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSiteTestFramework.Pages;
using WebSiteTestFramework;
using WebSiteTestFramework.Extensions;

namespace SeleniumCSharpExamples
{
    [TestClass]
    public class MSTestDriven : TestBase
    {     
        [TestMethod]
        [TestCategory("smoke")]
        public void TestTheSiteAlive()
        {
            Assert.IsTrue(Helper.IsTheWebSiteAliveAndUp());
        }
     
        [TestMethod]
        [TestCategory("smoke")]
        public void CanNavigateProjectsMenu()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.Projects();
            Assert.IsTrue(Pages.TopNavigation.CurrentURL().Equals("http://www.seleniumhq.org/projects/"));
        }

        [TestMethod]
        [TestCategory("smoke")]
        public void IsAtTheHomePage()
        {
            Pages.Home.Goto();
            Assert.IsTrue(Pages.Home.IsAt());
        }

        [TestInitialize]
        public void Initialize()
        {
            TestBase.Initialize();
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestBase.CleanUp();
        }
    }    
}
