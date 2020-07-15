using NewUnitProject.PajeObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security;

namespace NewUnitProject
{
    public class Tests
    {

        private IWebDriver _webDriver;
        private string _login = "Mytestmail92@tut.by";
        private string _password = "B00lIBN48";
        private string _userId = "3078328";

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://www.onliner.by/");

        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
                .SignIn()
                .Login(_login, _password)
                .PressProfileButton()
                .PressUserButton();

                
           var userAccount = new UserAccountPageObject(_webDriver);
           string Id = userAccount.SerchUserId();
           Assert.AreEqual(_userId, Id);
 

        }

       
        
    }
}