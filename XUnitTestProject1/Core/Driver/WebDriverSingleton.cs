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

        public IWebDriver GetIWebDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(ChromeStart.OptionsChrome());
            }

            return driver;
        }

        public static IWebDriver getWebDriver()
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                }
                return driver;
            }


        internal object Navigate()
        {
            throw new NotImplementedException();
        }
    }
}