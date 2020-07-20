using OpenQA.Selenium;
using XUnitTestProject1.Core.SeleniumMethods;

namespace NewUnitProject.PajeObject
{
    class UserAccountPageObject
    {
        private readonly By _profileName = By.CssSelector("div.profile-header__name");

        private GetText textName = new GetText();

        public string userIdSherch()
        {
            return textName.getText(_profileName);          
        }
    }
}
