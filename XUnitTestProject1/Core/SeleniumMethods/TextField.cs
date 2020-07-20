using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Core.SeleniumMethods
{
    internal class TextField : Waiters
    {
        public void type(By locator, string text)
        {
            WaitClicableElement(locator).SendKeys(text);
        }

        public void clear(By locator)
        {
            WaitClicableElement(locator).Clear();
        }
    }
}

