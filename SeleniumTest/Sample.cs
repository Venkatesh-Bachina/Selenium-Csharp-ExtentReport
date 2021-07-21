using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.screenshots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
   
        [TestFixture]
        public class Sample
        {
            ExtentReports extent;
            ExtentTest test;
            IWebDriver driver;

            [OneTimeSetUp]
            public void Init()
            {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("D:\\Selenium\\SeleniumTest\\SeleniumTest\\ExtentReports\\Demo.html");
            extent.AttachReporter(htmlReporter);
        }

            [Test]
            public void CaptureScreenshot()
            {
                test = extent.CreateTest("CaptureScreenshot");
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://www.automationtesting.in");
                string title = driver.Title;
                Assert.AreEqual("Home - Automation Test", title);
                test.Log(Status.Pass, "Test Passed");
            }

            [TearDown]
            public void GetResult()
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;

                if (status == TestStatus.Failed)
                {
                    string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                    test.Log(Status.Fail, stackTrace + errorMessage);
                    test.Log(Status.Fail, "Snapshot below: " + test.AddScreenCaptureFromPath(screenShotPath));
                }
               
            }

            [OneTimeTearDown]
            public void Endreport()
            {
                driver.Close();
                extent.Flush();
               
        }
    }

}

