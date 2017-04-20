using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.Tests.Enums;
using ToolsQA.Tests.Factories;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public abstract class PageTestsBase<TPage>
        where TPage : BasePage
    {
        protected Browser Browser { get; }
        protected IWebDriver PageDriver { get; private set; }
        protected TPage Page { get; private set; }

        protected abstract string PageToTest { get; }

        [SetUp]
        public void BeforeEachTest()
        {
            PageDriver = WebDriverFactory.CreateDriver(Browser);
            PageDriver.Manage().Window.Maximize();
            Page = PageFactory.Create<TPage>(PageToTest, PageDriver);
            Page.Navigate();
        }

        [TearDown]
        public void AfterEachTest()
        {
            PageDriver.Quit();
        }
    }
}
