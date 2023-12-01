using CreditCards.UITests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    class DashboardPage : Page
    {
        public DashboardPage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected override string PageUrl => "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
        protected override string PageTitle => "OrangeHRM";
        public IWebElement MyInfoButton => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[6]/a"));
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            DemoHelper.Pause();
        }
        public void MyInfo()
        { MyInfoButton.Click(); }

        //public MyInfoPage ClickonMyInfo()
        //{
        //    Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[6]/a")).Click();


        //    return new MyInfoPage(Driver);
        //}

        

        
    }
}
