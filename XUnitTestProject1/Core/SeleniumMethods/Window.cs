using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Core.SeleniumMethods
{
    class Window : Waiters
    {
        public void GoTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void WindowMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            driver.Close();
            driver = null;
        }
    }
}
