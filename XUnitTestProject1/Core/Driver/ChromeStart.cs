using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Core.Driver
{
    internal class ChromeStart
    {
        public static ChromeOptions OptionsChrome()
        {
            var optionsCh = new ChromeOptions();
            optionsCh.AddArgument("start-maximized");
            optionsCh.AddArguments("--lang=en-GB");
            return optionsCh;
        }
    }
}
