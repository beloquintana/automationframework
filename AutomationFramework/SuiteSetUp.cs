using AutomationFramework.Handler.ReportSeinglenton;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    [SetUpFixture]
    public class SuiteSetUp
    {
        [OneTimeSetUp]
        public void RunBeforerAnyTests()
        {
            //File.AppendAllText(@"C:\temp\MyTest.txt", "OneTimeSetUp1");
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            //File.AppendAllText(@"C:\temp\MyTest.txt", "OneTimeTearDown1");
            ReportSingelnton.Instance.Flush();
        }
    }
}
