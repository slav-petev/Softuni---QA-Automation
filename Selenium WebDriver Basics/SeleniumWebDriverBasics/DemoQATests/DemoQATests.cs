using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoQATests
{
    [TestFixture]
    public class DemoQATests
    {
        private IWebDriver _webDriver;
        private const string DemoQANavigationUrl = "http://www.demoqa.com";

        [SetUp]
        public void BeforeEachTest()
        {
            _webDriver = new ChromeDriver();
        }

        [Test]
        [Category("DemoQA")]
        public void ShouldOpenDemoQAPageCorrectly()
        {
            const string expectedUrl = "http://demoqa.com";

            _webDriver.Url = DemoQANavigationUrl;
            
            StringAssert.Contains(expectedUrl, _webDriver.Url);

            _webDriver.Quit();
        }

        [Test]
        [Category("DemoQA")]
        ////*[@id="pie_register"]/li[14]/div/input
        ////*[@id="pie_register"]/li[1]/div[1]/div[2]/span
        public void ShouldShowErrorMessageIfFirstNameTextBoxIsEmpty()
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Url = DemoQANavigationUrl;
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            IWebElement registrationButton = null;
            wait.Until(d => registrationButton = d.FindElement(By.XPath("//*[@id=\"menu-item-374\"]")));
            registrationButton.Click();

            IWebElement submitButton = null;
            wait.Until(d => submitButton = d.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input")));
            submitButton.Click();

            var errorMessage = _webDriver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));
            Assert.IsTrue(errorMessage.Displayed);

            _webDriver.Quit();
        }
    }
}
