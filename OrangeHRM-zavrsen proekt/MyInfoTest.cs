using CreditCards.UITests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHRM_zavrsen_proekt.OrangeHRM.UITest;
using OrangeHRM_zavrsen_proekt.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrangeHRM_zavrsen_proekt
{
    public class MyInfoTest : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        //private readonly LoginPage _loginPage;

        public MyInfoTest(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            //_loginPage = new LoginPage(_driver);

        }

        #region TestMyInfo
        [Fact]
        public void TestMyInfo()
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
                Assert.Contains("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewPersonalDetails/empNumber/7", driver.Url);
                driver.Quit();
            }
        }
        #endregion
    }
}
