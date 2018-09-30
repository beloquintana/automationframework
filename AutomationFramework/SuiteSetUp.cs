using AutomationFramework.Handler;
using NUnit.Framework;

namespace AutomationFramework
{
    [SetUpFixture]
    public class SuiteSetUp
    {
        [OneTimeSetUp]
        public void RunBeforerAnyTests()
        {

        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {            
            ReportHandler.Instance.Flush();
        }
    }
}
