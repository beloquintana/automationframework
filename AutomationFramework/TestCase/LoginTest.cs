using AutomationFramework.Handler;
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
            //ExtentTestManager.GetTest().Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            Test.Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            eyes.CheckWindow("Before mouse click");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin","admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

        [Test]
        public void SuccessfulLogin1()
        {
            //ExtentTestManager.GetTest().Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            Test.Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin1");
            eyes.CheckWindow("Before mouse click");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }

    [TestFixture]
    public class LoginTest2 : BaseTest
    {
        [Test]
        public void SuccessfulLogin2()
        {
            //ExtentTestManager.GetTest().Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            Test.Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            eyes.CheckWindow("Before mouse click");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

        [Test]
        public void SuccessfulLogin21()
        {
            //ExtentTestManager.GetTest().Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin");
            Test.Log(AventStack.ExtentReports.Status.Info, "SuccessfulLogin1");
            eyes.CheckWindow("Before mouse click");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }

    [TestFixture]
    public class LoginTest1 : BaseTest
    {
        [Test]
        public void EmptyPassword()
        {
            //ExtentTestManager.GetTest().Log(AventStack.ExtentReports.Status.Info, "EmptyPassword1");
            Test.Log(AventStack.ExtentReports.Status.Info, "EmptyPassword");
            eyes.CheckWindow("Before mouse click");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

        [Test]
        public void EmptyPassword1()
        {
            //ExtentTestManager.GetTest().Log(AventStack.ExtentReports.Status.Info, "EmptyPassword1");
            Test.Log(AventStack.ExtentReports.Status.Info, "EmptyPassword1");
            eyes.CheckWindow("Before mouse click");
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "");

            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }
}
