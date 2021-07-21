using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Basepage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest.pageobjects
{
    [TestFixture]
     public  class Pom : Base
      {
        //public IWebDriver driver;
       
        [Test]
        public void TestMethod()
        {
           test = extent.CreateTest("login").Info("Test");

            driver = new ChromeDriver();
            test.Log(Status.Pass,"chromelaunched");
            driver.Url = "https://opensource-demo.orangehrmlive.com";
            driver.Manage().Window.Maximize();
            var page1 = new Hrmlogin(driver);
            page1.login("Admin", "admin123");
            
            Thread.Sleep(2000);
            driver.Close();


        }
     }
}
