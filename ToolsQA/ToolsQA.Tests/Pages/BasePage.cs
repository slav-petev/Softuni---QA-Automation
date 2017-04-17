using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver WebDriver { get; private set; }
        protected WebDriverWait Wait { get; private set; }
        protected string Url { get; private set; }

        protected BasePage(IWebDriver webDriver, string url)
        {
            this.WebDriver = webDriver;
            this.Url = url;
            this.Wait = new WebDriverWait(this.WebDriver, TimeSpan.FromSeconds(
                Settings.WaitTimeout));
        }

        public void Navigate()
        {
            this.WebDriver.Navigate().GoToUrl(this.Url);
        }
    }
}
