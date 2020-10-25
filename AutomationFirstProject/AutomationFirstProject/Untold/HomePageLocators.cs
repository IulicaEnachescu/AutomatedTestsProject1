using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFirstProject.Untold
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
        IWebElement menuButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[3]/div/button")));
        IWebElement homeButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]")));
    }
}
////*[@id="untold-container"]/header/div[2]/div[3]/div/button
///////*[@id="untold-container"]/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]/span[1]/span
