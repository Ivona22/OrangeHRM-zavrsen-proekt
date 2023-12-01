using CreditCards.UITests;
using OpenQA.Selenium;

using OpenQA.Selenium.Support.UI;
using OrangeHRM_zavrsen_proekt.OrangeHRM.UITest;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace OrangeHRM_zavrsen_proekt.Pages
{
    public class LoginPage : Page
    {
        private readonly string validUsername;
        private readonly string validPassword;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            validUsername = "Admin";
            validPassword = " admin123";



            ////public LoginPage(IWebDriver driver)
            ////{
            ////    Driver = driver;
        }

        protected override string PageUrl => "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        protected override string PageTitle => "OrangeHRM";

        private IWebElement UsernameInput => Driver.FindElement(By.Name("username"));
        private IWebElement PasswordInput => Driver.FindElement(By.Name("password"));
        private IWebElement LoginButton => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button"));
        private IWebElement InvalidCredentilsText => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/div/div[1]"));

        private IWebElement ManuClick => Driver.FindElement(By.XPath("//li[@class='oxd-userdropdown' and @data-v-429cfcf3='' and @data-v-bdd6d943='' and @data-v-f0c5131f='']//i[@class='oxd-icon bi-caret-down-fill oxd-userdropdown-icon' and @data-v-bddebfba='' and @data-v-bdd6d943='']"));
        private IWebElement LogoutButton => Driver.FindElement(By.XPath(" //a[@href='/web/index.php/auth/logout' and @role='menuitem' and contains(@class, 'oxd-userdropdown-link')]"));
       
        #region LogInTest
        public void EnterUsername(string username)
        {
            UsernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
        #endregion
        #region LogOutTest
        public void DropdownManu()
        {
            ManuClick.Click();
        }

        public void LogoutClick()
        {
            LogoutButton.Click();
        }
        #endregion
        public class EnsureLogIn
        {

            private readonly LoginPage loginPage;

            public EnsureLogIn(LoginPage loginPage)
            {
                //this.loginPage = loginPage;
                loginPage.NavigateTo();
                DemoHelper.Pause();
                DemoHelper.Pause();
                DemoHelper.Pause();
            }
            
            public void WithCredentials(string username, string password)
            {
                loginPage.EnterUsername("Admin");
                loginPage.EnterPassword("admin123");
                loginPage.ClickLoginButton();
                WithCredentials(loginPage.validUsername, loginPage.validPassword);
               
                

            }

            
        }
    }
}

    


