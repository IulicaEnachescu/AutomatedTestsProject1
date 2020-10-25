using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFirstProject.Demoqua
{
   partial class TextBoxPage
    {

        protected IWebDriver _driver;
        private WebDriverWait _driverWait;
        public TextBoxPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }
     
        private IWebElement nameTextBox => _driver.FindElement(By.Id("userName"));
        private IWebElement emailTextBox => _driver.FindElement(By.Id("userEmail"));
        private IWebElement addressTextBox => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement permanentAddressTextBox => _driver.FindElement(By.Id("permanentAddress"));
        public IWebElement submitButton => _driver.FindElement(By.Id("submit"));
    }
}
