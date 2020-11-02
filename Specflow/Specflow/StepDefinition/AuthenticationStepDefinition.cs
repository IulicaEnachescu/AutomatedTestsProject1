using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Specflow.PageObjects;
using NUnit.Framework;

namespace Specflow.StepDefinition
{
    [Binding]
    public class AuthenticateStepDefinition:Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef


        
        [Given(@"I login user")]
        public void GivenILoginUser()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("admin.test3@gmail.com", "password123");
            Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        }

    }
}
