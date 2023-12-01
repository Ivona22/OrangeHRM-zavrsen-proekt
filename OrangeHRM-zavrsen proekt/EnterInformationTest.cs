using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OrangeHRM_zavrsen_proekt.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OrangeHRM_zavrsen_proekt.OrangeHRM.UITest;
using CreditCards.UITests;

namespace OrangeHRM_zavrsen_proekt
{


    [Trait("Category", "Applications")]
    public class EnterInformationTest : IClassFixture<ChromeDriverFixture>
    {
        private readonly ChromeDriverFixture ChromeDriverFixture;

        //[Fact]
        //public void EnterInformation()
        //{
        //    using (IWebDriver driver = new ChromeDriver()) ;

        //}
        //public class StayLogin : Page
        //{
        //    LoginPage LoginPage { get; set; }
        //}


        public EnterInformationTest(ChromeDriverFixture chromeDriverFixture)
        {
            ChromeDriverFixture = chromeDriverFixture;

            ChromeDriverFixture.Driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/7");

        }

        
        [Fact]
        public void BeInitiatedFromDashboardtoMyInfo()
        {
            var dashboardPage = new DashboardPage(ChromeDriverFixture.Driver);
            dashboardPage.EnsurePageLoaded();

            var myinfoPage = new MyInfoPage(ChromeDriverFixture.Driver);
            myinfoPage.EnsurePageLoaded();
            DemoHelper.Pause();
            DemoHelper.Pause();



        }




        #region Enter Date Test
        [Fact]
        public void EnterData()

        {
            using (IWebDriver driver = new ChromeDriver())
            {

                var loginPage = new LoginPage(driver); 
                DemoHelper.Pause();
                LoginPage.EnsureLogIn ensureLogIn = new LoginPage.EnsureLogIn(loginPage);
                DemoHelper.Pause();
                DemoHelper.Pause();
                
                loginPage.EnterUsername("Admin");
                DemoHelper.Pause();

                loginPage.EnterPassword("admin123");
                DemoHelper.Pause();

                loginPage.ClickLoginButton();
                DemoHelper.Pause();
                var dashboardPage = new DashboardPage(driver);

                
                dashboardPage.NavigateTo();
                DemoHelper.Pause();
                dashboardPage.MyInfo();
                DemoHelper.Pause();




                //FirstName
                var myinfoPage = new MyInfoPage(ChromeDriverFixture.Driver);


                IWebElement FirstNameInput = driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input oxd-input--active orangehrm-firstname' and @name='firstName' and @placeholder='First Name' and @data-v-1f99f73c='']"));
                DemoHelper.Pause();
                FirstNameInput.Click();

                IJavaScriptExecutor jsFirstName = (IJavaScriptExecutor)driver;
                jsFirstName.ExecuteScript("arguments[0].value = '';", FirstNameInput);
                FirstNameInput.SendKeys("Ivona");
                DemoHelper.Pause();


                //MiddleName
                IWebElement MiddleNameInput = driver.FindElement(By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space' and @data-v-957b4417='']//input[@class='oxd-input oxd-input--active orangehrm-middlename' and @name='middleName' and @placeholder='Middle Name' and @data-v-1f99f73c='']"));
                DemoHelper.Pause();
                MiddleNameInput.Click();

                IJavaScriptExecutor jsMiddleName = (IJavaScriptExecutor)driver;
                jsMiddleName.ExecuteScript("arguments[0].value = '';", MiddleNameInput);
                MiddleNameInput.SendKeys("Ivona");
                DemoHelper.Pause();

                //LastName
                IWebElement LastNameInput = driver.FindElement(By.XPath("//input[@class='oxd-input oxd-input--active orangehrm-lastname' and @name='lastName' and @placeholder='Last Name' and @data-v-1f99f73c='']"));
                DemoHelper.Pause();
                LastNameInput.Click();

                IJavaScriptExecutor jsLastName = (IJavaScriptExecutor)driver;
                jsLastName.ExecuteScript("arguments[0].value = '';", LastNameInput);
                LastNameInput.SendKeys("Nikoloska");
                DemoHelper.Pause();

                //NickName
                IWebElement NickNameInput = driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']/input[@class='oxd-input oxd-input--active' and @data-v-1f99f73c='']"));
                DemoHelper.Pause();
                NickNameInput.Click();

                IJavaScriptExecutor jsNickName = (IJavaScriptExecutor)driver;
                jsNickName.ExecuteScript("arguments[0].value = '';", NickNameInput);
                NickNameInput.SendKeys("Nikoloska");
                DemoHelper.Pause();



                //EmployeeID
                IWebElement EmployeeIDInput = driver.FindElement(By.XPath("//div[@class='' and @data-v-957b4417='']//input[@class='oxd-input oxd-input--active' and @data-v-1f99f73c='']"));
                DemoHelper.Pause();
                EmployeeIDInput.Click();

                IJavaScriptExecutor jsEmployeeID = (IJavaScriptExecutor)driver;
                jsEmployeeID.ExecuteScript("arguments[0].value = '';", EmployeeIDInput);
                EmployeeIDInput.SendKeys("123456");
                DemoHelper.Pause();

                //OtherID
                IWebElement OtherIDInput = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[1]/div[2]/div/div[2]/input"));
                DemoHelper.Pause();
                OtherIDInput.Click();

                IJavaScriptExecutor jsOtherID = (IJavaScriptExecutor)driver;
                jsOtherID.ExecuteScript("arguments[0].value = '';", OtherIDInput);
                OtherIDInput.SendKeys("654321");
                DemoHelper.Pause();


                //DriversLicenseNumber
                IWebElement DriverLicenseInput = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[1]/div/div[2]/input"));
                DemoHelper.Pause();
                DriverLicenseInput.Click();

                IJavaScriptExecutor jsDriverLicense = (IJavaScriptExecutor)driver;
                jsDriverLicense.ExecuteScript("arguments[0].value = '';", DriverLicenseInput);
                DriverLicenseInput.SendKeys("A-123456");
                DemoHelper.Pause();

                //ExpireNumber
                IWebElement ExpireInput = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[2]/div/div[2]/div/div/input"));
                DemoHelper.Pause();
                ExpireInput.Click();

                IJavaScriptExecutor jsExpire = (IJavaScriptExecutor)driver;
                jsExpire.ExecuteScript("arguments[0].value = '';", ExpireInput);
                ExpireInput.SendKeys("02-02-2023");
                DemoHelper.Pause();
                //Scroll
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0, 1000);");

                //*[@id="app"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div/form/div[2]/button
                //SaveButton
                IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div/form/div[2]/button"));
                DemoHelper.Pause();
                SaveButton.Click();
                DemoHelper.Pause();

                //bool successDisplay = myinfoPage.SuccessDisplayed();
                //Assert.True(successDisplay);



                //Assert.Equal($"{FirstName} {MiddleName}", completePage.NickName);
                //Assert.Equal(EmployeeID, completePage.EmployeeID);
                //Assert.Equal(LicenseNumber, completePage.DriversLicenseNumber);

            }

        }

        private static bool SuccessDisplayed(IWebDriver driver)
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
        #endregion
    }
}