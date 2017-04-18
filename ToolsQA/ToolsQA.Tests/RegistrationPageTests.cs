using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Factories;
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

            Assert.IsTrue(Page.NameRequiredErrorMessage.Displayed);
        }

        [Test]
        [Category("Registration Page")]
        public void ShouldDisplayErrorMessageIfTryinToRegisterWithoutLastName()
        {
            var user = UserFactory.CreateUser("WithoutLastName");

            Page.FirstNameInput.Clear();
            Page.FirstNameInput.SendKeys(user.FirstName);
            Page.RegistrationSubmit.Click();

            Assert.IsTrue(Page.NameRequiredErrorMessage.Displayed);
        }

        [Test]
        [Category("Registration Page")]
        public void ShouldDisplayErrorMessageIfTryingToRegisterWithoutHobbies()
        {
            var user = UserFactory.CreateUser("WithoutHobbies");

            Page.FirstNameInput.Clear();
            Page.FirstNameInput.SendKeys(user.FirstName);
            Page.LastNameInput.Clear();
            Page.LastNameInput.SendKeys(user.LastName);

            Page.RegistrationSubmit.Click();

            Assert.IsTrue(Page.HobbiesRequiredErrorMessage.Displayed);
        }
    }
}
