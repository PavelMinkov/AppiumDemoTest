using AppiumDemo.CapabilitiesFactory;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AppiumDemo.Driver
{
    public class AndroidDriverSingleton
    {
        private static AndroidDriver<AndroidElement> driver;

        public static AndroidDriver<AndroidElement> getDriver()
        {
            if (driver == null)
            {
                driver = new AndroidDriver<AndroidElement>(Capabilities.getAppiumServerUri(), Capabilities.getCapabilities());
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            }
            return driver;
        }
        public static void quitDriver()
        {
            driver.Quit();
        }
    }
}
