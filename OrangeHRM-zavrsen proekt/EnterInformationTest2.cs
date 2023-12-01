using CreditCards.UITests;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OrangeHRM_zavrsen_proekt.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrangeHRM_zavrsen_proekt
{
    [Trait("Category", "Applications")]
    public class EnterInformationTest2 : IClassFixture<ChromeDriverFixture>
    {
        private readonly ChromeDriverFixture ChromeDriverFixture;




        public EnterInformationTest2(ChromeDriverFixture chromeDriverFixture)
        {
            ChromeDriverFixture = chromeDriverFixture;

            ChromeDriverFixture.Driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/7");

        }
        [Fact]
        public void BeInitiatedFromDashboardtoMyInfo()
        {
            var dashboardPage = new DashboardPage(ChromeDriverFixture.Driver);
            dashboardPage.EnsurePageLoaded();

            var myinfoPage2 = new MyInfoPage2(ChromeDriverFixture.Driver);
            myinfoPage2.EnsurePageLoaded();
            DemoHelper.Pause();
            DemoHelper.Pause();



        }

        [Fact]
        public void EnterData()

        {
            using (IWebDriver driver = new ChromeDriver())
            {

                var loginPage = new LoginPage(driver); // driver е инстанца од IWebDriver, потребна за Selenium
                DemoHelper.Pause();
                LoginPage.EnsureLogIn ensureLogIn = new LoginPage.EnsureLogIn(loginPage);
                DemoHelper.Pause();
                DemoHelper.Pause();
                // Пример за успешна најава
                loginPage.EnterUsername("Admin");
                DemoHelper.Pause();

                loginPage.EnterPassword("admin123");
                DemoHelper.Pause();

                loginPage.ClickLoginButton();
                DemoHelper.Pause();
                var dashboardPage = new DashboardPage(driver);

                //LoginPage.Execute()
                dashboardPage.NavigateTo();
                DemoHelper.Pause();
                dashboardPage.MyInfo();
                DemoHelper.Pause();

                var myinfoPage2 = new MyInfoPage2(ChromeDriverFixture.Driver);
                DemoHelper.Pause();
                myinfoPage2.firstname();
                myinfoPage2.middlename();
                myinfoPage2.lastname();
                myinfoPage2.nickname();
                myinfoPage2.employeeID();
                myinfoPage2.otherID();
                myinfoPage2.driverlicensenumber();
                myinfoPage2.expiredate();
                myinfoPage2.scrolldown();
                myinfoPage2.save();
                bool successDisplay = myinfoPage2.SuccessDisplayed(driver);
                Assert.True(successDisplay);
            }
        }
    }
}
