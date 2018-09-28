using AutomationFramework.Handler;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.TestCase
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;
        protected string Url = "http://verstandqa.com/ejercicios/";

        //protected ExtentReports Extent;
        //protected ExtentTest Test;

        [OneTimeSetUp]
        protected void Setup()
        {            
            Console.WriteLine("OneTimeSetUp");
            //Extent = new ExtentReports();
            //Extent.AttachReporter(ReportHandler.ExtentHtmlReporter(TestContext.CurrentContext.TestDirectory, "Report"));
        }

        [SetUp]
        public void SetUpBase()
        {
            Console.WriteLine("SetUpBase");
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);

            //Test = Extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDownBase()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            //Test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            //Extent.Flush();
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            //Extent.Flush();
        }
    }
}
