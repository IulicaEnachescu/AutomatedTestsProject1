using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFirstProject.Demoqua
{
   partial class RegisterPage
    {
        protected IWebDriver _driver;
        private WebDriverWait _driverWait;
        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        IWebElement name => _driver.FindElement(By.Id("firstName"));
        IWebElement lastName => _driver.FindElement(By.Id("lastName"));
        IWebElement email => _driver.FindElement(By.Id("userEmail"));
        IWebElement gender => _driver.FindElement(By.XPath("//*[@id='genterWrapper']/div[2]/div[1]/label"));
        IWebElement phoneNumber => _driver.FindElement(By.Id("userNumber"));
        IWebElement dateOfBirth => _driver.FindElement(By.Id("dateOfBirthInput"));
        IWebElement subject => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='subjectsInput']")));
        IWebElement hobbies => _driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]"));
        IWebElement address => _driver.FindElement(By.Id("currentAddress"));

        private IWebElement state => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='react-select-3-input']")));
        private IWebElement city => _driver.FindElement(By.XPath("//*[@id='react-select-4-input']"));
        public IWebElement SubmitButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[type=submit]")));
        public IWebElement thanksForm => _driver.FindElement(By.XPath("//*[@id='example-modal-sizes-title-lg']"));
        // WebElement countrydropDown=driver.findElement(By.name("id_country"));
        //Select oSelectC = new Select(countrydropDown);
        //oSelectC.selectByVisibleText("United States")  
    }
}
