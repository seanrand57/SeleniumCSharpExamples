using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteTestFramework.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Return to Selenium home page")]
        private IWebElement homeLink;

        #region Properties

        protected override string PageName
        {
            get { return "Home Page"; }
        }

        protected override string RelativeUrl
        {
            get { return "/"; }
        }

        protected override string Title
        {
            get { return "Selenium - Web Browser Automation"; }
        }

        #endregion
       
        public void Goto()
        {
            Browser.GoHome();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Selenium - Web Browser Automation");
        }
    }
}
