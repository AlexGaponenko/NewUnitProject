using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject1.Core.SeleniumMethods;

namespace XUnitTestProject1.Tests
{
    public class StartTest : IDisposable
    {
        private readonly string url = "https://www.onliner.by/";
        Window window = new Window();
        public StartTest()
        {
            window.GoTo(url);
        }
        public void Dispose()
        {
            window.CloseBrowser();
        }
    }
}
