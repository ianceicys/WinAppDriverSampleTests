using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.iOS;
using System.Collections.Generic;

namespace RevitAppiumTests
{
    [TestClass]
    public class RevitScenarios
    {

        protected const string AppDriverUrl = "http://127.0.0.1:4723";
        protected const string RevitAppId = @"D:\Program Files\Autodesk\Revit 2016\Revit.exe";
        protected static IOSDriver<IOSElement> RevitSession;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            // Launch Revit Application
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", RevitAppId);
            RevitSession = new IOSDriver<IOSElement>(new Uri(AppDriverUrl), appCapabilities);
            Thread.Sleep(new TimeSpan(0, 0, 15));
            Assert.IsNotNull(RevitSession);
            RevitSession.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
        }

        [TestMethod]
        public void SkyScraperTestScenario()
        {
            var RevitMainWindows_1 = RevitSession.FindElementByTagName("Window");
            //var RevitMainWindows_2 = RevitSession.FindElementByName("Autodesk Revit 2016 R2 - [Recent Files]");

            //var RevitPane_1 = RevitSession.FindElementByName("AdApplicationButton");
            //var RevitPane_2 = RevitSession.FindElementByTagName("Pane");
            //var RevitPane_3 = RevitSession.FindElementByClassName("AdApplicationButton");

            //var RevitRibbon_Architecture1= RevitSession.FindElementByName("Architecture");
            //var RevitRibbon_Architecture2 = RevitSession.FindElementByAccessibilityId("Architecture");
        }
    }
}
