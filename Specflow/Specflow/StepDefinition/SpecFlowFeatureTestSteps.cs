using NUnit.Framework;
using Specflow.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Specflow.StepDefinitions
{
    [Binding]
    public class SpecFlowFeature1Steps : Hooks
    {

        [Given(@"I login with valid user")]
        public void GivenILoginWithValidUser()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("admin.test3@gmail.com", "password123");
            Assert.IsTrue(myHomePage.DeconectareButton.Displayed);

        }
    }
}
