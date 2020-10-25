using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace AutomationFirstProject.Demoqua
{
   partial class RegisterPage
    {
        public void Register()
        {
            name.SendKeys("Test");
            lastName.SendKeys("User");
            email.SendKeys("user@mail.com");
            gender.Click();
            phoneNumber.SendKeys("0733283321");
            dateOfBirth.SendKeys("20 Oct 2000");
            subject.SendKeys("nothing");
            subject.SendKeys(Keys.Tab);
            address.SendKeys("Paris");
            var x = hobbies.FindElements(By.TagName("label"));

            x.Where(i => i.Text.Equals("Sports")).FirstOrDefault().Click();
            state.SendKeys("NCR");
            state.SendKeys(Keys.Tab);
            city.SendKeys("Delhi");
            city.SendKeys(Keys.Tab);
            SubmitButton.Click();
            Thread.Sleep(200);
        }
    }
}
 

