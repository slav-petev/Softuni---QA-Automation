using NUnit.Framework;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests
{
    [TestFixture]
    public class RegistrationPageTests : PageTestsBase<RegistrationPage>
    {
        protected override string PageToTest => "Registration";
    }
}
