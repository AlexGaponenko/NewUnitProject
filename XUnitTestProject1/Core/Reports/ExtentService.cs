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

        static ExtentService()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\37529\source\repos\NewUnitProject\XUnitTestProject1\Extent.html");
            htmlReporter.Configuration().ChartLocation = ChartLocation.Top;
            htmlReporter.Configuration().ChartVisibilityOnOpen = true;
            htmlReporter.Configuration().DocumentTitle = "Extent/xUnit Samples";
            htmlReporter.Configuration().ReportName = "Extent/xUnit Samples";
            htmlReporter.Configuration().Theme = Theme.Standard;
            Instance.AttachReporter(htmlReporter);
        }

        //private ExtentService()
        //{
        //}


        //}
        //public class ExtentService
        //{
        //	private static readonly Lazy<ExtentReports> _lazy = new Lazy<ExtentReports>(() => new ExtentReports());

        //	public static ExtentReports Instance { get { return _lazy.Value; } }

        //	static ExtentService()
        //	{
        //		//var reporter = new ExtentHtmlReporter(Assembly.GetExecutingAssembly().Location + "\\Extent.html");
        //		var reporter = new ExtentHtmlReporter("c:\\Users\\37529\\source\\repos\\NewUnitProject\\Extent.html");
        //		reporter.Config.Theme = Theme.Standard;

        //		reporter.Config.DocumentTitle = "Extent/xUnit Samples";
        //		reporter.Config.ReportName = "Extent/xUnit Samples";
        //		Instance.AttachReporter(reporter);
        //	}

        //	private ExtentService()
        //	{

        //	}
        //}

        //}
    }
}

