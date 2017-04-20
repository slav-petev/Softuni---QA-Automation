using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using ToolsQA.Tests.Enums;

namespace ToolsQA.Tests.Factories
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    return new ChromeDriver();
                case Browser.Firefox:
                    return new FirefoxDriver();
                case Browser.Explorer:
                    return new InternetExplorerDriver();
                default:
                    throw new InvalidOperationException("Browser is not supported");
            }
        }
    }
}
