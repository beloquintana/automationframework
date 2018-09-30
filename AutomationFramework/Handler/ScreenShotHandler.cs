using OpenQA.Selenium;
using System.IO;
using System.Reflection;

namespace AutomationFramework.Handler
{
    public class ScreenShotHandler
    {
        private static string ImagePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string TakeScreenShot(IWebDriver driver, string ImageName)
        {
            string imagePath = ImagePath + "//"+ ImageName + ".png";
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(imagePath, ScreenshotImageFormat.Png);

            return imagePath;
        }
    }
}
