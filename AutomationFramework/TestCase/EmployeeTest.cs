using AutomationFramework.PO;
using NUnit.Framework;

namespace AutomationFramework.TestCase
{
    [TestFixture]
    public class EmployeeTest : BaseTest
    {
        private EmployeePage employeePage;

        [SetUp]
        public void BeforeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            employeePage = loginPage.LoginAs("admin", "admin123");
        }

        [TestCase("pepe", "pep@gmail.com", "Rio", "0945632")]
        [TestCase("lis", "lis@gmail.com", "Cuba", "5389552")]
        public void AddEmployee(string name, string email, string address, string phone)
        {
            Test.Log(AventStack.ExtentReports.Status.Info, "AddEmployee");
            eyes.CheckWindow("Add Employee Page");
            employeePage.AddEmployee(name, email, address, phone);

            Assert.IsTrue(employeePage.IsSuccessAlertPresent());
        }
    }
}
