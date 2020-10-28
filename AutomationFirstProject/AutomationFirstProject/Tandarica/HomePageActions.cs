
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFirstProject.Tandarica
{
    partial class HomePage
    {
        public void PageClick()
        {//move to element
            teamButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            actorButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 600)");
            showButton.Click();

        }
    }
}
