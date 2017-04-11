using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.Tests.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "entry-title")]
        public IWebElement Heading { get; set; }

        ////*[@id="menu-item-374"]/a
        //[FindsBy(How = How.XPath, Using = "//*[@id='menu-item-374']/a")]
        //public IWebElement RegistrationButton { get; set; }
        ////*[@id="menu-item-374"]/a
        public IWebElement RegistrationButton
        {
            get
            {
                return Wait.Until(d => d
                    .FindElement(By.XPath("//*[@id='menu-item-374']/a")));
            }
        }

        public HomePage(IWebDriver webDriver)
            : base(webDriver, "http://www.demoqa.com")
        {
            
        }
    }
}
