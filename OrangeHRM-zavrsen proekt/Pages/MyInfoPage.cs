using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCards.UITests;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    class MyInfoPage : Page
    {
        private readonly object ExpectedConditions;

        public MyInfoPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public MyInfoPage ClickonMyInfo()
        {
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[6]/a")).Click();


            return new MyInfoPage(Driver);
        }

        protected override string PageUrl => "https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/7";
        protected override string PageTitle => "OrangeHRM";
        public IWebElement FirstNameInput => Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input oxd-input--active orangehrm-firstname' and @name='firstName' and @placeholder='First Name' and @data-v-1f99f73c='']"));
        public void Click()
        {
           FirstNameInput.Click();
           
        }
        public IWebElement ClearButton => Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input*/*/ oxd-input--active orangehrm-firstname' and @name='firstName' and @placeholder='First Name' and @data-v-1f99f73c='']"));
       
        public void Clear()
        {

            FirstNameInput.Clear();
            FirstNameInput.SendKeys("Ivona");
            System.Threading.Thread.Sleep(3000);
        }

        public void EnterFirstName(string FirstName)


        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement firstNameInput = Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input oxd-input--active orangehrm-firstname' and @name='firstName' and @placeholder='First Name' and @data-v-1f99f73c='']"));

            firstNameInput.Clear(); // Очисти го влезот пред да внесеш нова вредност
            firstNameInput.SendKeys(FirstName);
        }
       ///*public void EnterFirstName(string FirstName) => Driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input*/*/ oxd-input--active orangehrm-firstname' and @name='firstName' and @placeholder='First Name' and @data-v-1f99f73c*/='']")).SendKeys(FirstName);

        public void EnterMiddleName(string MiddleName) => Driver.FindElement(By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space' and @data-v-957b4417='']//input[@class='oxd-input oxd-input--active orangehrm-middlename' and @name='middleName' and @placeholder='Middle Name' and @data-v-1f99f73c='']")).SendKeys(MiddleName);

        public void EnterNickName(string NickName) => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[1]/div[2]/div/div")).SendKeys(NickName);

        public void EnterEmployeeId(string EmployeeID) => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[1]/div[1]/div")).SendKeys(EmployeeID);
        public void EnterOtherID(string OtherID) => Driver.FindElement(By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space' and @data-v-957b4417='']//input[@class='oxd-input oxd-input--active' and @data-v-1f99f73c='']"));
        public void EnterDriversLicenseNumber(string LicenseNumber) => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[1]/div")).SendKeys(LicenseNumber);
        private IWebElement SaveButton => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div/form/div[2]/button"));
        private IWebElement EnterLicenseExpiryDate => Driver.FindElement(By.XPath("//i[@class='oxd-icon bi-calendar oxd-date-input-icon' and @data-v-bddebfba='' and @data-v-4a95a2e0='']"));
        public void EnterDate()
        {
            EnterLicenseExpiryDate.Click();
            EnterLicenseExpiryDate.Clear();
            EnterLicenseExpiryDate.SendKeys("05-12-2023");
        }


        // public void EnterLicenseExpiryDate(string ExpiryDate) => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[2]/div")).SendKeys(ExpiryDate);

        //public void ChooseMaritalStatusSingle() => Driver.FindElement(By.Id("Single")).Click();

        //public void AcceptTerms() => Driver.FindElement(By.Id("TermsAccepted")).Click();

        //public void ChooseBusinessSourceTV()
        //{
        //    IWebElement businessSourceSelectElement = Driver.FindElement(By.Id("BusinessSource"));
        //    SelectElement businessSource = new SelectElement(businessSourceSelectElement);
        //    businessSource.SelectByValue("TV");
        //}
        //public void Clear()
        //{ ClearButton.Clear(); }
        //public void ScrollDownthePage()
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        //    // IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //    //js.ExecuteScript("window.scrollBy(0, 1000);");
        //}

        public void   SubmitApplication()
        {
            SaveButton.Click();
        }
        //public bool SuccessDisplayed()
        //{
        //    try
        //    {
        //        IWebElement successDisplay = Driver.FindElement(By.XPath("//*[@id=\"oxd-toaster_1\"]"));
        //        return successDisplay.Displayed;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false; // Return false if the element is not found
        //    }
        //}
    }
}


