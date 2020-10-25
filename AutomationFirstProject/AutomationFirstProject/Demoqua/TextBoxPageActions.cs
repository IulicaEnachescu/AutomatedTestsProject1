using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFirstProject.Demoqua
{
    partial class TextBoxPage
    {

        public void FillTextBox()
        {

            nameTextBox.SendKeys("User User");
            emailTextBox.SendKeys("user@mail.com");
            addressTextBox.SendKeys("Roma");
            permanentAddressTextBox.SendKeys("Milano");
            submitButton.Click();
            Thread.Sleep(400);
        }
    }
}
