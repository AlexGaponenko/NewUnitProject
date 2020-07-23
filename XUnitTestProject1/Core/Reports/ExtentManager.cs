using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace XUnitTestProject1.Core.Reports
{
    public class ExtentManager
    {
        private static ExtentReports report = new ExtentReports();

        static ExtentManager()
        {
            var htmlReporter = new ExtentHtmlReporter(@"c:\Users\37529\source\repos\NewUnitProject\XUnitTestProject1\Core\Reports\MyTestReport.html");
            htmlReporter.
            report.AttachReporter(htmlReporter);
        }
    }
}
