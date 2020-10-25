
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
        {
            teamButton.Click();
            Thread.Sleep(1000);
            actorButton.Click();
            Thread.Sleep(1000);
            showButton.Click();
        }
    }
}
