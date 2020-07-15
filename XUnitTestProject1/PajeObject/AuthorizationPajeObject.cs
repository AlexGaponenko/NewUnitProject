using OpenQA.Selenium;
using System.Threading;

namespace NewUnitProject.PajeObject
{
    class AuthorizationPajeObject
    {
        private IWebDriver _webDriver;

        private readonly By _loginInput = By.CssSelector("div[class^=auth-input] input[type^=text]");
        private readonly By _passwordInput = By.CssSelector("input[type^=password]");
        private readonly By _continueButton = By.CssSelector("div[class^=auth-form] button[type^=submit]");


        public AuthorizationPajeObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
         
        }



        public MainMenuPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_loginInput).SendKeys(login);
            _webDriver.FindElement(_passwordInput).SendKeys(password);
            Thread.Sleep(400);
            _webDriver.FindElement(_continueButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
