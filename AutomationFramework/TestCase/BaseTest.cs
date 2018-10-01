using Applitools.Selenium;
using AutomationFramework.Handler;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace AutomationFramework.TestCase
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;
        protected string Url = ConfigurationManager.AppSettings["Url"];

        protected ExtentReports Extent;
        protected ExtentTest Test;
        protected Eyes eyes;
        
        [SetUp]
        public void BeforeBaseTest()
        {
            Test = ReportHandler.Instance.CreateTest(TestContext.CurrentContext.Test.Name);
            Driver = new ChromeDriver();
            eyes = new Eyes();
            eyes.ApiKey = ConfigurationManager.AppSettings["API_Key"];
                        
            eyes.Open(Driver, "AutomationFramework", TestContext.CurrentContext.Test.Name);
            Driver.Url = Url;
        }

        [TearDown]
        public void AfterBaseTest()
        {
            try
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
                        Test.AddScreenCaptureFromPath(ScreenShotHandler.TakeScreenShot(Driver, TestContext.CurrentContext.Test.Name));
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

                Test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
                LogApplitools();
            }
            catch (Exception e)
            {
                Test.Log(Status.Error, "Exception " + e.Message);
            }
            finally
            {
                if (Driver != null)
                {
                    Driver.Quit();
                }
            }            
        }

        private void LogApplitools()
        {
            var throwtTestCompleteException = false;
            Applitools.TestResults result = eyes.Close(throwtTestCompleteException);
            string url = result.Url;
            if (result.IsNew)
                Test.Log(Status.Info, "New Baseline Created: URL=" + url);
            else if (result.IsPassed)
                Test.Log(Status.Info, "Visual check Passed: URL=" + url);
            else
                Test.Log(Status.Info, "Visual check Failed: URL=" + url);
        }
    }
}
