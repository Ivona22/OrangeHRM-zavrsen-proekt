using CreditCards.UITests;
using OpenQA.Selenium;
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
    public class LoginValidPassTest : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginValidPassTest(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPage = new LoginPage(_driver);

        }


        #region SuccessfulLogin
        [Fact]
        public void SuccessfulLogin()
        {
            _loginPage.NavigateTo();
            DemoHelper.Pause();
            _loginPage.EnterUsername("Admin");
            DemoHelper.Pause();
            
            _loginPage.EnterPassword("admin123");
            DemoHelper.Pause();
            
            _loginPage.ClickLoginButton();
            DemoHelper.Pause();
            
            

            Assert.Contains("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index", _driver.Url);
        }
        #endregion
        #region LogOut
        [Fact]
        public void Logout()
        {
            _loginPage.NavigateTo();
            DemoHelper.Pause();
            _loginPage.EnterUsername("Admin");
            DemoHelper.Pause();

            _loginPage.EnterPassword("admin123");
            DemoHelper.Pause();

            _loginPage.ClickLoginButton();
            DemoHelper.Pause();

            _loginPage.DropdownManu();
            DemoHelper.Pause();
            _loginPage.LogoutClick();

           
            DemoHelper.Pause();
            

            Assert.Contains("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", _driver.Url);
        }
        #endregion
    }
}