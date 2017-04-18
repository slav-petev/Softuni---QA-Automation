using NUnit.Framework;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Factories;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public class HomePageTests : PageTestsBase<HomePage>
    {
        protected override string PageToTest => "Home";

        [Test]
        [Category("Home Page")]
        public void ShouldLoadHomePageCorrectly()
        {
            Assert.AreEqual("Home", Page.Heading.Text);
        }

        [Test]
        [Category("Home Page")]
        public void ShouldNavigateToRegistrationPageCorrectly()
        {
            Page.RegistrationButton.Click();

            Assert.AreEqual(Settings.Url.ToolQARegistrationPageUrl, PageDriver.Url);
        }
    }
}
