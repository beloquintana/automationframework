using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Handler
{
    public class ScreenShotHandler
    {
        private static string ImagePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static void TakeScreenShot(IWebDriver driver)
        {
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(ImagePath + "//Images//IMG2.png", ScreenshotImageFormat.Png);
        }
    }
}
