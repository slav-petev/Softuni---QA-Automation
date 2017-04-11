using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ToolsQA.Tests.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement Heading
        {
            get
            {
                return Wait.Until(d =>
                    d.FindElement(By.ClassName("entry-title")));
            }
        }

        
        public IWebElement RegistrationButton
        {
            get
            {
                return this.Wait.Until(d => 
                    d.FindElement(By.XPath("//*[@id=\"menu-item-374\"]/a")));
            }
        }

        public HomePage(IWebDriver webDriver)
            : base(webDriver, "http://www.demoqa.com")
        {
            
        }
    }
}
