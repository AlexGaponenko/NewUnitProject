using OpenQA.Selenium;
using System.Threading;

namespace NewUnitProject.PajeObject
{
    class MainMenuPageObject 
    {
        private IWebDriver driver;

        private readonly By _signInButton = By.CssSelector("div[class^=auth-bar] div[class$=text]");
        private readonly By _profileButton = By.CssSelector("div[class^=b-top-profile__item] a[class^=b-top-profile__preview]");
        private readonly By _userButton = By.CssSelector("div.b-top-profile__name a[class^=b-top-profile__link]");
        private readonly By _profileName = By.CssSelector("div.profile-header__name");

        public MainMenuPageObject(IWebDriver webDriver) 
        {
            driver = webDriver;
        }

        public AuthorizationPajeObject SignIn()
        {
            driver.FindElement(_signInButton).Click();
            return new AuthorizationPajeObject(driver);
        }

        public MainMenuPageObject PressProfileButton()
        {
            Thread.Sleep(800);
            driver.FindElement(_profileButton).Click();
            return new MainMenuPageObject(driver);
        }

        public UserAccountPageObject PressUserButton()
        {
            Thread.Sleep(300);
            driver.FindElement(_userButton).Click();
            return new UserAccountPageObject (driver);
        }

      public string SerchUserId()
      {
          string userLogin = driver.FindElement(_profileName).Text;
          return userLogin;
      }
    }
}
