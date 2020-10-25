using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFirstProject.GooglePageObjects
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
        ~ HomePage()
        {
            _driver.Close();
        }
        IWebElement search => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name("q")));
        public IWebElement imageFrame => _driver.FindElement(By.XPath("//*[@id='Sva75c']"));
        IWebElement acceptButton => _driver.FindElement(By.XPath("//*[@id='introAgreeButton']"));
        IWebElement image=> _driver.FindElement(By.XPath("//*[@id='hdtb-msb-vis']/div[2]/a"));
         IWebElement firstImage => _driver.FindElement(By.XPath("//*[@id='islrg']/div[1]/div[1]/a[1]/div[1]/img"));

    }
}
