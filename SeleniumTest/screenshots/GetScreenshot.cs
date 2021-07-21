using OpenQA.Selenium;
using System;
using System.Collections.Generic;





using OpenQA.Selenium.Chrome;
using System.IO;

namespace SeleniumTest.screenshots
{

    public class GetScreenshot
    {
        

        // IWebDriver driver;
        public static string Capture( IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshots\\" + screenShotName +" .Png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;


        }

        
    }
}

