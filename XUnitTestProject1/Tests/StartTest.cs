using System;
using XUnitTestProject1.Core.Reports;
using XUnitTestProject1.Core.SeleniumMethods;


namespace XUnitTestProject1.Tests
{
    public class StartTest : IDisposable
    {


        private readonly string url = "https://www.onliner.by/";
        Window window = new Window();
        //private ExtentTest test;

        public  StartTest()
        {
            window.GoTo(url);
        }
        public void Dispose()
        {
            ExtentService.Instance.Flush();
            //window.CloseBrowser();
        }
    }
}
