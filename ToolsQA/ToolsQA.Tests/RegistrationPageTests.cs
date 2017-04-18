using NUnit.Framework;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public class RegistrationPageTests : PageTestsBase<RegistrationPage>
    {
        protected override string PageToTest => "Registration";

        [Test]
        [Category("Registration Page")]
        public void ShouldLoadRegistrationPageCorrectly()
        {
            Assert.AreEqual("Registration", Page.Heading.Text);
        }

        [Test]
        [Category("Registration Page")]
        public void ShouldDisplayErrorMessageIfTryingToRegisterWithoutFirstName()
        {
            Page.RegistrationSubmit.Click();

            Assert.IsTrue(Page.RequiredFieldErrorMessage.Displayed);
        }

    }
}
