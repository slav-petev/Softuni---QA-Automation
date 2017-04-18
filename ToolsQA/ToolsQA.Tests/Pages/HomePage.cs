using OpenQA.Selenium;
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
            : base(webDriver, Settings.Url.ToolsQATopLevelUrl)
        {
            
        }
    }
}
