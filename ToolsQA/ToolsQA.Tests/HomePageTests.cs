using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public class HomePageTests : PageTestsBase<HomePage>
    {
        protected override string PageToTest { get { return "Home"; } }

        [Test]
        [Category("Home Page")]
        public void ShouldNavigatoToHomePageCorrectly()
        {
            Assert.AreEqual("Home", Page.Heading.Text);
        }

        [Test]
        [Category("Home Page")]
        public void ShouldNavigateToRegistrationPageCorrectly()
        {
            Page.RegistrationButton.Click();

            Assert.AreEqual(Settings.ToolQARegistrationPageUrl, PageDriver.Url);
        }
    }
}
