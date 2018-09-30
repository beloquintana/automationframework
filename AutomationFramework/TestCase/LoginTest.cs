using AutomationFramework.PO;
using NUnit.Framework;

namespace AutomationFramework.TestCase
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            Test.Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            eyes.CheckWindow("Login Page");

            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin","admin123");
            
            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }

    /*[TestFixture]
    public class LoginTest1 : BaseTest
    {
        [Test]
        public void EmptyPassword()
        {
            Test.Log(AventStack.ExtentReports.Status.Info, "EmptyPassword");
            eyes.CheckWindow("Login Page");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "");

            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }*/
}
