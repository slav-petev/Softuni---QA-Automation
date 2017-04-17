using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public class RegistrationPageTests : PageTestsBase<RegistrationPage>
    {
        protected override string PageToTest => "Registration";
    }
}
