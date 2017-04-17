using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Tests.Factories;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public abstract class PageTestsBase<TPage>
        where TPage : BasePage
    {
        protected IWebDriver PageDriver { get; private set; }
        protected TPage Page { get; private set; }

        protected abstract string PageToTest { get; }

        [SetUp]
        public void BeforeEachTest()
        {
            PageDriver = new ChromeDriver();
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
