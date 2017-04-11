using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver webDriver) 
            : base(webDriver, Settings.ToolQARegistrationPageUrl)
        {
        }
    }
}
