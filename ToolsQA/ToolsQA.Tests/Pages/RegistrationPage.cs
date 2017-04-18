using OpenQA.Selenium;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public class RegistrationPage : BasePage
    {
        ////*[@id="post-49"]/header/h1
        public IWebElement Heading =>
            Wait.Until(d => d.FindElement(By
                .XPath("//*[@id=\"post-49\"]/header/h1")));

        ////*[@id="pie_register"]/li[14]/div/input
        public IWebElement RegistrationSubmit =>
            Wait.Until(d => d.FindElement(By
                .XPath("//*[@id=\"pie_register\"]/li[14]/div/input")));

        ////*[@id="pie_register"]/li[1]/div[1]/div[2]/span
        public IWebElement RequiredFieldErrorMessage =>
            Wait.Until(d => d.FindElement(By
                .CssSelector("[class='legend error']")));

        public RegistrationPage(IWebDriver webDriver) 
            : base(webDriver, Settings.Url.ToolQARegistrationPageUrl)
        {
        }
    }
}
