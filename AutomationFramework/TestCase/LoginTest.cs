using AutomationFramework.PO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.TestCase
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin","admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

        [Test]
        public void EmptyPassword()
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "");

            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }
}
