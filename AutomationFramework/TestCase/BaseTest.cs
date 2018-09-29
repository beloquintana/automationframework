using Applitools.Selenium;
using AutomationFramework.Handler;
using AutomationFramework.Handler.ReportSeinglenton;
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
        protected ExtentTest Test;
        protected Eyes eyes;

        [OneTimeSetUp]
        protected void Setup()
        {
            //ExtentTestManager.CreateParentTest(GetType().Name);
            //Extent = new ExtentReports();
            //Extent.AttachReporter(ReportHandler.ExtentHtmlReporter(TestContext.CurrentContext.TestDirectory, "Report"));
        }

        [SetUp]
        public void SetUpBase()
        {
            Test = ReportSingelnton.Instance.CreateTest(TestContext.CurrentContext.Test.Name);
            //ExtentTestManager.CreateTest(TestContext.CurrentContext.Test.Name);
            Driver = new ChromeDriver();
            eyes = new Eyes();
            eyes.ApiKey = "12Fp101Ks104fGAtKeG7HEDM2NCRe9kuTsF3XPUw9Ib71vE110";
                        
            eyes.Open(Driver, "AutomationFramework", TestContext.CurrentContext.Test.Name);
            Driver.Url = Url;



            //Driver.Navigate().GoToUrl(Url);

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

            Test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            var throwtTestCompleteException = false;
            Applitools.TestResults result = eyes.Close(throwtTestCompleteException);
            string url = result.Url;
            if (result.IsNew)
            {
                Console.WriteLine("New Baseline Created: URL=" + url);
            }
            else if (result.IsPassed)
            {
                Console.WriteLine("All steps passed:     URL=" + url);
            }
            else
            {
                Console.WriteLine("Test Failed:          URL=" + url);
            }
            //Extent.Flush();
            //ExtentTestManager.GetTest().Log(logstatus, "Test ended with " + logstatus + stacktrace);
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            //ExtentManager.Instance.Flush();
            //Extent.Flush();
        }
    }
}
