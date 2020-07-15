using OpenQA.Selenium;


namespace NewUnitProject.PajeObject
{
    class UserAccountPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _profileName = By.CssSelector("div.profile-header__name");

        public UserAccountPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string SerchUserId()
        {   
            string userLogin = _webDriver.FindElement(_profileName).Text;
            return userLogin;
        }

 
    }
}
