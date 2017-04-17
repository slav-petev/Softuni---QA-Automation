using System.Configuration;

namespace ToolsQA.Tests.Common
{
    public static class Settings
    {
        public static readonly int WaitTimeout =
            int.Parse(ConfigurationManager.AppSettings["WaitTimeout"]);

        public static readonly string ToolsQATopLevelUrl =
            ConfigurationManager.AppSettings["DemoQATopUrl"];

        public static readonly string ToolQARegistrationPageUrl =
            string.Format("{0}{1}", ToolsQATopLevelUrl, 
                ConfigurationManager.AppSettings["DemoQARegistrationPageRelativeUrl"]);
    }
}
