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
    public class FindJobTest : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly HomePageforUsers homePageforUsers;
        private IWebElement ClickJobApplication;

        public FindJobTest(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            homePageforUsers = new HomePageforUsers(_driver);
        }
        #region CarrersTest
        [Fact]
        public void CarrersTest()
        {
            var homePageforUsers = new HomePageforUsers(_driver);
            homePageforUsers.LoadingHomePageforUsers();
            DemoHelper.Pause();

            homePageforUsers.ElementToHoverOver2();
            DemoHelper.Pause();
            homePageforUsers.ElementToClick2();
            DemoHelper.Pause();

            var carrersPage = new CarrersPage(_driver);
            carrersPage.LoadingCarrersPage();
            DemoHelper.Pause();
            carrersPage.ScrollDown();
            DemoHelper.Pause();
            carrersPage.ClickOpenSurce();
            DemoHelper.Pause();

            var oursurcesPage = new OurSurcesPage(_driver);
            oursurcesPage.LoadingOurSurcesPage();
            DemoHelper.Pause();

            

            Assert.Contains("https://www.orangehrm.com/en/orangehrm-starter-open-source-software/", _driver.Url);



        }
        #endregion
    }
}