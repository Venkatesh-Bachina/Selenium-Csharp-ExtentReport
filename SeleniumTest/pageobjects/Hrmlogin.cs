using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTest.pageobjects
{
  public  class Hrmlogin
  {
        IWebDriver driver;
        public Hrmlogin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.Id,Using = "txtUsername" )]
        public IWebElement Name{ get; set; }

       
        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement ok { get; set; }

        public void login(String u, String p)
        {

           
            Name.Clear();
            Name.SendKeys(u);
            pass.Clear();
            pass.SendKeys(p);
            ok.Click();
            //string title = driver.Title;
            //Assert.AreEqual("Home - Automation Test", title);
            
        }



  }
}
