using CreditCards.UITests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    public class ChangingLanguageTest : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly HomePageforUsers homePageforUsers;

        public ChangingLanguageTest(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            homePageforUsers = new HomePageforUsers(_driver);

        }
        #region LanguageTest
        [Fact]
        public void LanguageTest()
        {
            var homePageforUsers = new HomePageforUsers(_driver);
            homePageforUsers.LoadingHomePageforUsers();
            DemoHelper.Pause();

            homePageforUsers.ElementToHoverOver();
            homePageforUsers.ElementToClick();
           

            Assert.Contains("https://www.orangehrm.com/es/", _driver.Url);
           
        }
        #endregion


    }
}
