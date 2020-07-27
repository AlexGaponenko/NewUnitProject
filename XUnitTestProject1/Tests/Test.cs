using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NewUnitProject.PajeObject;
using System;
using Xunit;
using XUnitTestProject1.Core.Reports;
using XUnitTestProject1.Core.SeleniumMethods;
using XUnitTestProject1.Tests;
namespace XUnitTestProject1
{
    public class Test : IClassFixture<StartTest>, IDisposable
    {
        private readonly string url = "https://www.onliner.by/";
        
        private string _loginRight = "Mytestmail92@tut.by";
        private string _passwordRight = "B00lIBN48";
        private string _userId = "3078328";
        private string _loginNotRight = "VitalMartal@mail.ru";
        private string _passwordNotRight = "12345678";
        private string _messegeWrongLoginOrPassword = "Неверный логин или пароль";

        Window window = new Window();
        MainMenuPageObject MainMenu = new MainMenuPageObject();
        AuthorizationPajeObject AuthPage = new AuthorizationPajeObject();
        UserAccountPageObject UserAcc = new UserAccountPageObject();
        public Test()
        {
            window.GoTo(url);
        }
        public void Dispose()
        {  
            window.CloseBrowser();
        }

        [Fact]
            public void Test1()
            {
            MainMenu.openLoginMenu();
                AuthPage.TypeText(_loginRight, _passwordRight);
                MainMenu.clicProfileButton();
                Assert.True(MainMenu.waitMenu());
                MainMenu.clicUserButton();
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

            [Fact]
            public void Test3()
            {
            ExtentTestManager.CreateTest(GetType().Name);
            MainMenu.openLoginMenu();
            }



        }

    
 }
