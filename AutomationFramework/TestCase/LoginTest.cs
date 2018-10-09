using AutomationFramework.PO;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace AutomationFramework.TestCase
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            Test.Log(Status.Info, "SuccessfulLogin");
            eyes.CheckWindow("Login Page");

            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin","admin123");
            
            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }
}
