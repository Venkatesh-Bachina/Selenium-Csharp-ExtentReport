using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.screenshots;
using System;
using System.Threading;




namespace Selenium
    {
        class Radiobutton
        {
            IWebDriver driver;




            [SetUp]
            public void Setup()
            {
                driver = new ChromeDriver();
            }



            [Test]
            public void Test1()
            {
                driver.Url = "https://www.automationtestinginsider.com/2019/08/student-registration-form.html";
                IWebElement radioBtn = driver.FindElement(By.XPath("//input[@type='radio' and @value='Male']"));
                radioBtn.Click();
                
               



                Console.WriteLine("Male radio btn is Selected: " + radioBtn.Selected);
                Thread.Sleep(2000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(5000);
               // var GetScreenshot = new GetScreenshot();
                //GetScreenshot.capture(driver);
                driver.Quit();




            }
        }





    }

