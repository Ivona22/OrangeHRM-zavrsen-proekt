using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    class CompletePage : Page
    {
        public CompletePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected override string PageUrl => "https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/7";
        protected override string PageTitle => "OrangeHRM";

        public string FirstName=> Driver.FindElement(By.Name("firstName")).Text;
        public string MiddleName => Driver.FindElement(By.Name("middleName")).Text;
        public string NickName => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[1]/div[2]/div/div/div[2]/input")).Text;
        public string EmployeeID => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[1]/div[1]/div/div[2]/input")).Text;
        public string DriversLicenseNumber => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[1]/div/div[2]/input")).Text;
       
    }
}
