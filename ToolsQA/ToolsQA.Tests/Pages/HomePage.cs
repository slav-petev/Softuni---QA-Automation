using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement Heading =>
            Wait.Until(d => d.FindElement(By.ClassName("entry-title")));

        public IWebElement RegistrationButton =>
            Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"menu-item-374\"]/a")));
        
        public HomePage(IWebDriver webDriver)
            : base(webDriver, Settings.ToolsQATopLevelUrl)
        {
            
        }
    }
}
