using CreditCards.UITests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    public class MyInfoPage2 : Page
    {
        private readonly object ExpectedConditions;

            public MyInfoPage2(IWebDriver driver)
            {
                Driver = driver;
            }
        protected override string PageUrl => "https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/7";
        protected override string PageTitle => "OrangeHRM";
        
       
        
        public void firstname()
        {
            IWebElement FirstNameInput = Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input oxd-input--active orangehrm-firstname' and @name='firstName' and @placeholder='First Name' and @data-v-1f99f73c='']"));
            DemoHelper.Pause();
            FirstNameInput.Click();

            IJavaScriptExecutor jsFirstName = (IJavaScriptExecutor)Driver;
            jsFirstName.ExecuteScript("arguments[0].value = '';", FirstNameInput);
            FirstNameInput.SendKeys("Ivona");
            DemoHelper.Pause();
        }
        public void middlename()
        {
            IWebElement MiddleNameInput = Driver.FindElement(By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space' and @data-v-957b4417='']//input[@class='oxd-input oxd-input--active orangehrm-middlename' and @name='middleName' and @placeholder='Middle Name' and @data-v-1f99f73c='']"));
            DemoHelper.Pause();
            MiddleNameInput.Click();

            IJavaScriptExecutor jsMiddleName = (IJavaScriptExecutor)Driver;
            jsMiddleName.ExecuteScript("arguments[0].value = '';", MiddleNameInput);
            MiddleNameInput.SendKeys("Ivona");
            DemoHelper.Pause();
        }
        public void lastname()
        {
            IWebElement LastNameInput = Driver.FindElement(By.XPath("//input[@class='oxd-input oxd-input--active orangehrm-lastname' and @name='lastName' and @placeholder='Last Name' and @data-v-1f99f73c='']"));
            DemoHelper.Pause();
            LastNameInput.Click();

            IJavaScriptExecutor jsLastName = (IJavaScriptExecutor)Driver;
            jsLastName.ExecuteScript("arguments[0].value = '';", LastNameInput);
            LastNameInput.SendKeys("Nikoloska");
            DemoHelper.Pause();
        }
        public void nickname()
        {
            IWebElement NickNameInput = Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input oxd-input--active' and @data-v-1f99f73c='']"));
            DemoHelper.Pause();
            NickNameInput.Click();

            IJavaScriptExecutor jsNickName = (IJavaScriptExecutor)Driver;
            jsNickName.ExecuteScript("arguments[0].value = '';", NickNameInput);
            NickNameInput.SendKeys("Nikoloska");
            DemoHelper.Pause();
        }
        public void employeeID()
        {
            IWebElement EmployeeIDInput = Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']//input[@class='oxd-input oxd-input--active' and @data-v-1f99f73c='']"));
            DemoHelper.Pause();
            EmployeeIDInput.Click();

            IJavaScriptExecutor jsEmployeeID = (IJavaScriptExecutor)Driver;
            jsEmployeeID.ExecuteScript("arguments[0].value = '';", EmployeeIDInput);
            EmployeeIDInput.SendKeys("123456");
            DemoHelper.Pause();
        }
        public void otherID()
        {
            IWebElement OtherIDInput = Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[1]/div[2]/div/div[2]/input"));
            DemoHelper.Pause();
            OtherIDInput.Click();

            IJavaScriptExecutor jsOtherID = (IJavaScriptExecutor)Driver;
            jsOtherID.ExecuteScript("arguments[0].value = '';", OtherIDInput);
            OtherIDInput.SendKeys("654321");
            DemoHelper.Pause();
        }
        public void driverlicensenumber()
        {
            IWebElement DriverLicenseInput = Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[1]/div/div[2]/input"));
            DemoHelper.Pause();
            DriverLicenseInput.Click();

            IJavaScriptExecutor jsDriverLicense = (IJavaScriptExecutor)Driver;
            jsDriverLicense.ExecuteScript("arguments[0].value = '';", DriverLicenseInput);
            DriverLicenseInput.SendKeys("A-123456");
            DemoHelper.Pause();
        }
        public void expiredate()
        {
            IWebElement ExpireInput = Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[2]/div/div[2]/div/div/input"));
            DemoHelper.Pause();
            ExpireInput.Click();

            IJavaScriptExecutor jsExpire = (IJavaScriptExecutor)Driver;
            jsExpire.ExecuteScript("arguments[0].value = '';", ExpireInput);
            ExpireInput.SendKeys("02-02-2023");
            DemoHelper.Pause();
        }
        public void scrolldown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 1000);");
        }
        public void save()
        {
            IWebElement SaveButton = Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div/form/div[2]/button"));
            DemoHelper.Pause();
            SaveButton.Click();
            DemoHelper.Pause();
        }
        public bool SuccessDisplayed(IWebDriver driver)
        {
            try
            {
                IWebElement successDisplay = driver.FindElement(By.XPath("//*[@id=\"oxd-toaster_1\"]"));
                return successDisplay.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; // Return false if the element is not found
            }

        }
    }
}
