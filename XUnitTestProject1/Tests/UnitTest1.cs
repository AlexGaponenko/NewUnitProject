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
    public class UnitTest1 : IDisposable
    {
        

        private readonly string url = "https://www.onliner.by/";

        Window window = new Window();
        public MainMenuPageObject MainMenu;
 //       public AuthorizationPajeObject AuthPage;

        public UnitTest1()
        {   
           
            window.GoTo(url);
            window.WindowMaximize();
            
        }
        public void Dispose()
        {
            window.CloseBrowser();
        }

    }


        public class TestOne : UnitTest1
        {

        private string _loginRight = "Mytestmail92@tut.by";
        private string _passwordRight = "B00lIBN48";
        private string _userId = "3078328";
        private string _loginNotRight = "VitalMartal@mail.ru";
        private string _passwordNotRight = "12345678";
        private string _messegeWrongLoginOrPassword = "Неверный логин или пароль";

        MainMenuPageObject MainMenu = new MainMenuPageObject();
        AuthorizationPajeObject AuthPage = new AuthorizationPajeObject();
        UserAccountPageObject UserAcc = new UserAccountPageObject();
          
       [Fact]
         public void Test1()
         {
           MainMenu.openLoginMenu();
           AuthPage.TypeText(_loginRight,_passwordRight);
           MainMenu.clicProfileButton();
           Thread.Sleep(300);
           MainMenu.clicUserButton();
            UserAcc.userIdSherch();
           Assert.Equal(_userId, UserAcc.userIdSherch());
  
         }

        [Fact]
        public void Test2()
        {
            MainMenu.openLoginMenu();
            AuthPage.TypeText(_loginNotRight, _passwordNotRight);
            AuthPage.messageIdentefication();
            Assert.Equal(_messegeWrongLoginOrPassword, AuthPage.messageIdentefication());
        }

        }

 
 }
