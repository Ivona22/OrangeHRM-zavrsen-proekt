using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    class CarrersPage : Page
    {
        public CarrersPage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected override string PageUrl => "https://www.orangehrm.com/en/company/careers/";
        protected override string PageTitle => "OrangeHRM Careers: Join Our Team | OrangeHRM";
        

        private IWebElement OpenSurceButton => Driver.FindElement(By.XPath("/html/body/footer/section/div[2]/div/div/div[2]/div/ul/li[1]/a"));
        public void LoadingCarrersPage()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            NavigateTo();
        }
        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            // IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //js.ExecuteScript("window.scrollBy(0, 1000);");
        }
        public void ClickOpenSurce()
        {
            OpenSurceButton.Click();
        }
        

        
    }
}
