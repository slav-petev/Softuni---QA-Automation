using OpenQA.Selenium;
using System.Collections.Generic;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public class RegistrationPage : BasePage
    {
        public IWebElement Heading =>
            Wait.Until(d => d.FindElement(By
                .XPath("//*[@id=\"post-49\"]/header/h1")));

        public IWebElement RegistrationSubmit =>
            Wait.Until(d => d.FindElement(By
                .XPath("//*[@id=\"pie_register\"]/li[14]/div/input")));

        public IWebElement FirstNameInput =>
            Wait.Until(d => d.FindElement(By
                .Id("name_3_firstname")));
        ////*[@id="pie_register"]/li[1]/div[1]/div[2]/span
        public IWebElement NameRequiredErrorMessage =>
            Wait.Until(d => d.FindElement(By
                .XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span")));

        public IWebElement LastNameInput =>
            Wait.Until(d => d.FindElement(By
                .Id("name_3_lastname")));

        public IEnumerable<IWebElement> HobbyCheckBoxes =>
            Wait.Until(d => d.FindElements(By
                .CssSelector("input[type='checkbox']")));
        public IWebElement HobbiesRequiredErrorMessage =>
            Wait.Until(d => d.FindElement(By
                .XPath("//*[@id=\"pie_register\"]/li[3]/div/div[2]/span")));

        public IWebElement CountryDropdown =>
            Wait.Until(d => d.FindElement(By
                .Id("dropdown_7")));

        public RegistrationPage(IWebDriver webDriver) 
            : base(webDriver, Settings.Url.ToolQARegistrationPageUrl)
        {
        }
    }
}
