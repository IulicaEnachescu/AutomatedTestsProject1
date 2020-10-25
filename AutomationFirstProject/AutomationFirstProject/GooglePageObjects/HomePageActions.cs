using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFirstProject.GooglePageObjects
{
    partial class HomePage
    {
        public void AcceptGoogleTerms()
        {
            acceptButton.Click();
        }
        public void Search(string element)
        {
            search.SendKeys(element); // send also a "\n"
            search.Submit();
        }
        public void SelectGoogleImage()
        {
            image.Click();
            firstImage.Click();
        }
   
        

        //public void SearchGoogleImage(string query)
        //{
        //    searchTextBox.SendKeys(query);
        //    searchTextBox.SendKeys(Keys.Return);
        //}
    
    }
}

    //IWebElement search => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name("q")));
    //public IWebElement imageFrame => _driver.FindElement(By.XPath("//*[@id='Sva75c']"));
    //IWebElement acceptButton => _driver.FindElement(By.XPath("//*[@id='introAgreeButton']"));
    //IWebElement image => _driver.FindElement(By.XPath("//*[@id='hdtb-msb-vis']/div[2]/a"));
    //IWebElement firstImage => _driver.FindElement(By.XPath("//*[@id='islrg']/div[1]/div[1]/a[1]/div[1]/img"));