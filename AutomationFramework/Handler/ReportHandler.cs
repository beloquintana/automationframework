using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Handler
{
    public class ReportHandler
    {
        public static ExtentHtmlReporter ExtentHtmlReporter(string reportPath, string fileName)
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath + "\\" + fileName + ".html");
            htmlReporter.LoadConfig(reportPath + "\\" + "extent-config.xml");
            return htmlReporter;
        }
    }
}
