using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Core.Driver
{
    internal class WebDriverSingleton
    {
            private static IWebDriver driver;

        public static IWebDriver GetIWebDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(ChromeStart.OptionsChrome());
            }

            return driver;
        }


        internal object Navigate()
        {
            throw new NotImplementedException();
        }
    }
}