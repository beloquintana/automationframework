using AutomationFramework.Handler;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PO
{
    public class EmployeePage : BasePage
    {
        protected By Form = By.Id("formEmployee");

        public EmployeePage(IWebDriver driver)
        {
            Driver = driver;

            if (Driver.Title.Equals("AUT From"))
                throw new Exception("This is not the Employee page");
        }

        public bool FormIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, Form);
        }
    }
}
