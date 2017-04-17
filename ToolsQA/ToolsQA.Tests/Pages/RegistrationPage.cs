using OpenQA.Selenium;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver webDriver) 
            : base(webDriver, Settings.ToolQARegistrationPageUrl)
        {
        }
    }
}
