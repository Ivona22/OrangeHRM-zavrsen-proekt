using CreditCards.UITests;
using OpenQA.Selenium;

using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using OrangeHRM_zavrsen_proekt.OrangeHRM.UITest;
using OrangeHRM_zavrsen_proekt.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace OrangeHRM_zavrsen_proekt
{
    public class LoginTests : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginTests(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPage = new LoginPage(_driver);

        }


        #region UnseccessfullLoginTest
        [Fact]
        public void UnSuccessfulLogin()
        {
            _loginPage.NavigateTo();
            DemoHelper.Pause();

            _loginPage.EnterUsername("Admin");
            DemoHelper.Pause();
            _loginPage.EnterPassword("admin1234");
            DemoHelper.Pause();
            _loginPage.ClickLoginButton();
            DemoHelper.Pause();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement alertElement = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(@class, 'oxd-alert') and contains(@class, 'oxd-alert--error')]")));
            string result = alertElement.FindElement(By.XPath(".//p[contains(@class, 'oxd-text') and contains(@class, 'oxd-text--p') and contains(@class, 'oxd-alert-content-text')]")).Text;
            Console.WriteLine(result);

           
            Assert.Contains("Invalid credentials", result);

            
            Assert.Contains("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", _driver.Url);
            DemoHelper.Pause();
        }
        #endregion
    }






}



    







