using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.PageObjects
{
    public class BasePO
    {
        protected AppiumDriver<AndroidElement> driver;
        public BasePO(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
    }
}
