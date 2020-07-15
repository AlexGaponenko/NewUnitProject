using OpenQA.Selenium;
using System.Threading;

namespace NewUnitProject.PajeObject
{
    class MainMenuPageObject 
    {
        private IWebDriver _webDriver;

        private readonly By _signInButton = By.CssSelector("div[class^=auth-bar] div[class$=text]");
        private readonly By _profileButton = By.CssSelector("div[class^=b-top-profile__item] a[class^=b-top-profile__preview]");
        private readonly By _userButton = By.CssSelector("div.b-top-profile__name a[class^=b-top-profile__link]");
        private readonly By _profileName = By.CssSelector("div.profile-header__name");

        public MainMenuPageObject(IWebDriver webDriver) 
        {
            _webDriver = webDriver;
        }

        public AuthorizationPajeObject SignIn()
        {
            _webDriver.FindElement(_signInButton).Click();
            return new AuthorizationPajeObject(_webDriver);
        }

        public MainMenuPageObject PressProfileButton()
        {
            Thread.Sleep(800);
            _webDriver.FindElement(_profileButton).Click();
            return new MainMenuPageObject(_webDriver);
        }

        public UserAccountPageObject PressUserButton()
        {
            Thread.Sleep(300);
            _webDriver.FindElement(_userButton).Click();
            return new UserAccountPageObject (_webDriver);
        }

      public string SerchUserId()
      {
          string userLogin = _webDriver.FindElement(_profileName).Text;
          return userLogin;
      }
    }
}
