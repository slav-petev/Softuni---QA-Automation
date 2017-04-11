using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver _homePageDriver;
        private HomePage _homePage;

        [SetUp]
        public void BeforeEachTest()
        {
            _homePageDriver = new ChromeDriver();
            _homePageDriver.Manage().Window.Maximize();
            _homePage = new HomePage(_homePageDriver);
            _homePage.Navigate();
            
        }

        [Test]
        [Category("Home Page")]
        public void ShouldNavigatoToHomePageCorrectly()
        {
            Assert.AreEqual("Home", _homePage.Heading.Text);
        }

        [Test]
        [Category("Home Page")]
        public void ShouldNavigateToRegistrationPageCorrectly()
        {
            _homePage.RegistrationButton.Click();

            Assert.AreEqual("http://demoqa.com/registration/", _homePageDriver.Url);

        }

        [TearDown]
        public void AfterEachTest()
        {
            _homePageDriver.Quit();
        }
    }
}
