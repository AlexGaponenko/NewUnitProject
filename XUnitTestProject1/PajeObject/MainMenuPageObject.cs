using OpenQA.Selenium;
using System.Threading;
using XUnitTestProject1.Core.SeleniumMethods;

namespace NewUnitProject.PajeObject
{
    public class MainMenuPageObject 
    {
       private readonly By _signInButton = By.CssSelector("div[class^=auth-bar] div[class$=text]");
       private readonly By _profileButton = By.CssSelector("div[class^=b-top-profile__item] a[class^=b-top-profile__preview]");
       private readonly By _userButton = By.CssSelector("div.b-top-profile__name a[class^=b-top-profile__link]");

       private Button button = new Button();

        public void openLoginMenu()
        {
            button.click(_signInButton);
        }

        public void clicProfileButton()
        {
            button.click(_profileButton);
        }

        public void clicUserButton()
        {
            button.click(_userButton);
        }

    }
}
