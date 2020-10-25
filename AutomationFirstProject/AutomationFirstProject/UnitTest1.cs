using System;
using System.Threading;
using AutomationFirstProject;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFirstProject
{
    [TestFixture]
    public class UnitTest1:Hooks
    {


        [Test]
        public void FirstTestGoogle()
        {
            //ARRANGE
            Driver.Navigate().GoToUrl("https://www.google.com/search");
            GooglePageObjects.HomePage homePageGoogle = new GooglePageObjects.HomePage(Driver);
            //ACT

            Driver.SwitchTo().Frame(0);
            homePageGoogle.AcceptGoogleTerms();
            homePageGoogle.Search("paris");
            homePageGoogle.SelectGoogleImage();
            Driver.Navigate().Back();

            //ASSERT
            Assert.IsTrue(!homePageGoogle.imageFrame.Displayed);
        }
        [Test]
        public void SecondTestDemoQARegister()
        {
            //ARRANGE
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Demoqua.RegisterPage page = new Demoqua.RegisterPage(Driver);

            // Act
            page.Register();
            //Assert
            Assert.IsTrue(page.thanksForm.Displayed);

        }
        [Test]
        public void ThirdTestDemoQATextBox()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            //Arrange
            Demoqua.TextBoxPage page = new Demoqua.TextBoxPage(Driver);

            //Act
            page.FillTextBox();

            //Assert
            var element = Driver.FindElement(By.Id("name"));
            Assert.IsTrue(element.Displayed);
        }
        [Test]
        public void FourthTestTandarica()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");

            // Arrange
            Tandarica.HomePage page = new Tandarica.HomePage(Driver);

            // Act
            page.PageClick();

            //Assert
            Assert.IsTrue(page.showNameText.Displayed);
        }

        [Test]
        public void FifthTestUntoldPage()
        {
            // Arrange
            Driver.Navigate().GoToUrl("https://untold.com/");
            Untold.HomePage page = new Untold.HomePage(Driver);

            // Act
            page.ClickPage();

            // Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='untold-wrap']/div[3]/div[1]")).Displayed);
        }
    }
        
}
