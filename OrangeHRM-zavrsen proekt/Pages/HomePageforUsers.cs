using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    class HomePageforUsers : Page
    {
        public HomePageforUsers (IWebDriver driver)
        {
            Driver = driver;
        }

        protected override string PageUrl => "https://www.orangehrm.com/";
        protected override string PageTitle => "OrangeHRM HR Software | OrangeHRM";
        

        private IWebElement ESLanguage => Driver.FindElement(By.Name("ES"));

         private IWebElement elementToHoverOver => Driver.FindElement(By.XPath("//div[@class='lan-ul']/div[@class='lan-1']/a"));
         private  IWebElement elementToClickAfterHover => Driver.FindElement(By.XPath("//div[@class='lan-ul']/div[@class='lan-2']/a"));
        private IWebElement elementToHoverOver2 => Driver.FindElement(By.XPath("//*[@id=\"navbarSupportedContent\"]/ul/li[4]/a"));
        private IWebElement elementToClickAfterHover2 => Driver.FindElement(By.XPath("//a[@href=\"/en/company/careers/\"]"));
        //private IWebElement ClickJobApplication => Driver.FindElement(By.XPath("//span[@class=\"col l12 vacancy-name\" and contains(text(), \"Job Application - Associate Technical Support Engineer /Technical Support Engineer (Night Shift - Roster)\")]"));
        
        //private IWebElement ApplyButton => Driver.FindElement(By.XPath("//a[@class=\"btn action-btn applyButtonLink\" and contains(text(), \"Apply\")]"));

        #region ChangeLanguage
        public void ElementToHoverOver()
        {

            Actions actions = new Actions(Driver);
            actions.MoveToElement(elementToHoverOver).Perform();
        }
        public void ElementToClick()
        {
          
                elementToClickAfterHover.Click();
           
        }

        public void LoadingHomePageforUsers()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            NavigateTo();
        }

        //public void ClickESLanguage()
        //{
        //    ESLanguage.Click();
        //}
        #endregion Careers
        public void ElementToHoverOver2()
        {

            Actions actions = new Actions(Driver);
            actions.MoveToElement(elementToHoverOver2).Perform();
        }
        public void ElementToClick2()
        {

            elementToClickAfterHover2.Click();

        }
        

    }
}
