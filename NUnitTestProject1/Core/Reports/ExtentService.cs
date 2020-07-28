using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace XUnitTestProject1.Core.Reports
{
    public class ExtentService
    {
        private static readonly Lazy<ExtentReports> _lazy = new Lazy<ExtentReports>(() => new ExtentReports());


        public static ExtentReports Instance { get { return _lazy.Value; } }


            static  ExtentService()
            {
            //var reporter = new ExtentHtmlReporter(Assembly.GetExecutingAssembly().Location + "\\Extent.html");
            var reporter = new ExtentV3HtmlReporter(@"c:\Users\37529\source\repos\NewUnitProject1\Extent.html");
                reporter.Config.Theme = Theme.Standard;

                reporter.Config.DocumentTitle = "Extent/nUnit Samples";
                reporter.Config.ReportName = "Extent/nUnit Samples";
            
                Instance.AttachReporter(reporter);
            }

            private ExtentService()
            {

            }




        //static ExtentService()
        //{
        //    var htmlReporter = new ExtentHtmlReporter(@"C:\Users\37529\source\repos\NewUnitProject\NUnitTestProject1\Extent222.html");
        //    htmlReporter.Configuration().ChartLocation = ChartLocation.Top;
        //    htmlReporter.Configuration().ChartVisibilityOnOpen = true;
        //    htmlReporter.Configuration().DocumentTitle = "Extent/xUnit Samples";
        //    htmlReporter.Configuration().ReportName = "Extent/xUnit Samples";
        //    htmlReporter.Configuration().Theme = Theme.Dark;
        //    Instance.AttachReporter(htmlReporter);
        //}

        //private ExtentService()
        //{
        //}


        //}

    }
}



