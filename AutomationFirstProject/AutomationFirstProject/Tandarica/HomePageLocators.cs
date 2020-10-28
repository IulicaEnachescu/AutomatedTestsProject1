using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFirstProject.Tandarica
{
   partial class HomePage
    {
        protected IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement teamButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu-item-2914']/a/span[2]")));
        private IWebElement actorButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-masonry-1-item-2697']/figure/div/div")));
        private IWebElement showButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]")));
        public IWebElement showNameText => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[2]/div/div/h3")));


    }
}
////*[@id="av-layout-grid-1"]/div[1]/div/div[1]/section/div/p[2]/a/strong