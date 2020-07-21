using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Core.Driver
{
    internal class ChromeStart
    {
        public static FirefoxOptions OptionsChrome()
        {
            var optionsCh = new FirefoxOptions();
            optionsCh.AddArgument("start-maximized");
            optionsCh.AddArguments("--lang=en-GB");
            return optionsCh;
        }
    }
}
