using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SoftUniTests
{
    [TestFixture]
    public abstract class SoftUniNavigationTestsBase
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void BeforeEachTest()
        {
            _webDriver = CreateDriver();
        }

        protected abstract IWebDriver CreateDriver();

        //[Test]
        //[TestCase("/html/body/div[1]/div[5]/div/div/div/h1", "Курс QA Automation - март 2017")]
        //[TestCase("/html/body/div[2]/div[2]/div/article/div[1]/h2", "Курс QA Automation - март 2017")]
        //public void ShouldContainElementWhicContainsSpecifiedText(string xPath,
        //    string expectedText)
        //{
        //    _webDriver.Manage().Window.Maximize();

        //    _webDriver.Url = "http://softuni.bg";
        //    _webDriver.Url = "https://softuni.bg/trainings/1584/qa-automation-march-2017";

        //    var webDriverWait = new WebDriverWait(_webDriver,
        //        TimeSpan.FromSeconds(30));

        //    var tag = webDriverWait.Until(w => 
        //        w.FindElement(By.XPath(xPath)));
        //    StringAssert.Contains(expectedText, tag.Text);

        //    _webDriver.Quit();
        //}

        [Test]
        public void ShouldFindH1TagWithSpecifiedTextCorrectly()
        {
            _webDriver.Manage().Window.Maximize();

            _webDriver.Url = "http://softuni.bg";
            _webDriver.Url = "https://softuni.bg/trainings/1584/qa-automation-march-2017";

            var webDriverWait = new WebDriverWait(_webDriver,
                TimeSpan.FromSeconds(30));

            var h1Tag = webDriverWait.Until(w =>
               w.FindElement(By.XPath("/html/body/div[1]/div[5]/div/div/div/h1")));
            StringAssert.Contains("Курс QA Automation - март 2017", h1Tag.Text);

            _webDriver.Quit();
        }

        [Test]
        public void ShouldFindH2TagWithSpecifiedTextCorrectly()
        {
            _webDriver.Manage().Window.Maximize();

            _webDriver.Url = "http://softuni.bg";
            _webDriver.Url = "https://softuni.bg/trainings/1584/qa-automation-march-2017";

            var webDriverWait = new WebDriverWait(_webDriver,
                TimeSpan.FromSeconds(30));

            var h2Tag = webDriverWait.Until(w =>
               w.FindElement(By.XPath("/html/body/div[2]/div[2]/div/article/div[1]/h2")));
            StringAssert.Contains("Курс QA Automation - март 2017", h2Tag.Text);

            _webDriver.Quit();
        }

        [TearDown]
        public void AfterEachTest()
        {
            if (_webDriver == null) return;

            _webDriver.Quit();
            _webDriver = null;
        }
    }
}
