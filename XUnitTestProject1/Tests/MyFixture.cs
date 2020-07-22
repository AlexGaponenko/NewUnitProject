using NewUnitProject.PajeObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Xunit;
using XUnitTestProject1.Core.Driver;
using XUnitTestProject1.Core.SeleniumMethods;

namespace XUnitTestProject1
{
    public class MyFixture : IDisposable
    {
        private readonly string url = "https://www.onliner.by/";


                 Window window = new Window();
                 public MyFixture()
                 {
                 window.GoTo(url);
                 }
                 public void Dispose()
                 {
                     window.CloseBrowser();
                 }  
}
        public class TestOne : MyFixture
        {


        //private string _loginRight = "Mytestmail92@tut.by";
        //private string _passwordRight = "B00lIBN48";
        //private string _userId = "3078328";
        //private string _loginNotRight = "VitalMartal@mail.ru";
        //private string _passwordNotRight = "12345678";
        //private string _messegeWrongLoginOrPassword = "Неверный логин или пароль";

                 MainMenuPageObject MainMenu = new MainMenuPageObject();
                 //AuthorizationPajeObject AuthPage = new AuthorizationPajeObject();
                 //UserAccountPageObject UserAcc = new UserAccountPageObject();
          
            [Fact]
             public void Test1()
             {
            
                 MainMenu.openLoginMenu();
                 //AuthPage.TypeText(_loginRight,_passwordRight);
                 //MainMenu.clicProfileButton();
                 //Assert.True(MainMenu.waitMenu());
                 //MainMenu.clicUserButton();
                 //Assert.Equal(_userId, UserAcc.userIdSherch());
            
             }

             [Fact]
             public void Test2()
             {
                 MainMenu.openLoginMenu();
                 //AuthPage.TypeText(_loginNotRight, _passwordNotRight);
                 //AuthPage.messageIdentefication();
                 //Assert.Equal(_messegeWrongLoginOrPassword, AuthPage.messageIdentefication());
             }
      
             [Fact]
             public void Test3()
             {
                 MainMenu.openLoginMenu();
             }



        }

 
 }
