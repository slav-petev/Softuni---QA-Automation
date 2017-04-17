using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests.Factories
{
    public static class PageFactory
    {
        private static readonly Dictionary<string, Type> _pageTypes =
            new Dictionary<string, Type>();

        static PageFactory()
        {
            var pageTypes = Assembly.GetExecutingAssembly()
                .GetTypes().Where(t => t.IsSubclassOf(typeof(BasePage)));
            
            foreach (var pageType in pageTypes)
            {
                var pageTypeName = pageType.Name.Replace("Page", string.Empty);
                _pageTypes.Add(pageTypeName, pageType);
            }
        }

        public static TPage Create<TPage>(string pageName, IWebDriver pageDriver)
            where TPage : BasePage
        {
            if (!_pageTypes.ContainsKey(pageName))
                throw new InvalidOperationException();

            return Activator.CreateInstance(_pageTypes[pageName],
                pageDriver) as TPage;
        }
    }
}
