using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{

    public class Tests
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
            //driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.Close();
            //Assert.Pass();
        }
    }
}