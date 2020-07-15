using NewUnitProject.PajeObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1 : IAsyncDisposable
    {
        protected IWebDriver driver { get; set; }

        public UnitTest1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.onliner.by/");
            
 //         public void Dispose()
 //         {
 //             driver.Close();
 //         }

        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }




        public class TestOne : UnitTest1
        {
            private IWebDriver _webDriver;
            private string _login = "Mytestmail92@tut.by";
            private string _password = "B00lIBN48";
            private string _userId = "3078328";
            
            [Fact]
            public void Test1()
            {
                var mainMenu = new MainMenuPageObject(driver);
                 mainMenu
                     .SignIn()
                     .Login(_login, _password)
                     .PressProfileButton()
                     .PressUserButton();
  
  
                 var userAccount = new UserAccountPageObject(driver);
                 string Id = userAccount.SerchUserId();
                 Assert.Equal(Id, _userId);
                
            }
        }

 
 }
