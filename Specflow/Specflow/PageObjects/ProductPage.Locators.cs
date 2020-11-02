using OpenQA.Selenium;

namespace Specflow.PageObjects
{
    partial class ProductPage
    {
        private IWebElement AdaugaInCosButton => _driver.FindElement(By.CssSelector(".btn-primary"));
    }
}
