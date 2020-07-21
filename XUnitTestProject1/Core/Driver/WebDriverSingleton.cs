using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Core.Driver
{
    internal class WebDriverSingleton
    {

        private static readonly Lazy<WebDriverSingleton> lazy = new Lazy<WebDriverSingleton>(() => new WebDriverSingleton());
        public static WebDriverSingleton instanse => lazy.Value;

        private IWebDriver driver;

        public IWebDriver GetIWebDriver()
        {
            if (driver == null) 
            {
                driver = new FirefoxDriver(ChromeStart.OptionsChrome()); 
            }

            return driver;
        }

    }
}