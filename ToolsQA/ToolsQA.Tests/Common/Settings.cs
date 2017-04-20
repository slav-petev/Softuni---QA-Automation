using NUnit.Framework;
using System.Configuration;
using System.IO;

namespace ToolsQA.Tests.Common
{
    public static class Settings
    {
        public static readonly int WaitTimeout =
            int.Parse(ConfigurationManager.AppSettings["WaitTimeout"]);

        public static class Url
        {
            public static readonly string ToolsQATopLevelUrl =
                ConfigurationManager.AppSettings["DemoQATopUrl"];

            public static readonly string ToolQARegistrationPageUrl =
                string.Format("{0}{1}", ToolsQATopLevelUrl,
                    ConfigurationManager.AppSettings["DemoQARegistrationPageRelativeUrl"]);
        }

        public static class TestData
        {
            private static readonly string TestDataPath =
                Path.Combine(TestContext.CurrentContext.TestDirectory,
                    ConfigurationManager.AppSettings["TestDataRelativePath"]);
            private static readonly string TestDataConnectionStringTemplate =
                ConfigurationManager.AppSettings["TestDataConnectionString"];
            public static readonly string TestDataConnectionString =
                string.Format(TestDataConnectionStringTemplate, TestDataPath);
        } 
    }
}
