using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_zavrsen_proekt.Pages
{
    class OurSurcesPage : Page
    {
        public OurSurcesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected override string PageUrl => "https://www.orangehrm.com/en/orangehrm-starter-open-source-software/";
        protected override string PageTitle => "Free HR Software | Open Source | OrangeHRM";

        public void LoadingOurSurcesPage()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            NavigateTo();
        }
    }
}
