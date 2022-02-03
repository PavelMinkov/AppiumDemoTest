using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.PageObjects
{
    public class InitialPO : BasePO
    {
        public InitialPO(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }
        private readonly string GotItBTN = "welcome_tour_got_it";
        private readonly string TakeMeToGmailBTN = "action_done";
        private readonly string GotItPopUpBTN = "next_button";

        private readonly string NavigationBTN = "//*[@content-desc='Open navigation drawer']";
        private readonly string PrimaryBTN = "//*[@text='Primary']";

        private readonly string SubjectText = "//android.view.ViewGroup[1]/android.widget.TextView[3]";


        public InitialPO ClickGotItBTN()
        {
            driver.FindElementById(GotItBTN).Click();
            return this;
        }

        public InitialPO ClickTakeMeToGmailBTN()
        {
            driver.FindElementById(TakeMeToGmailBTN).Click();
            return this;
        }
        public InitialPO ClickGotItPopUpBTN()
        {
            driver.FindElementById(GotItPopUpBTN).Click();
            return this;
        }

        public InitialPO ClickNavigationBTN()
        {
            driver.FindElementByXPath(NavigationBTN).Click();
            return this;
        }
        public InitialPO ClickPrimaryBTN()
        {
            driver.FindElementByXPath(PrimaryBTN).Click();
            return this;
        }
        public string GetSubjectText()
        {
            return driver.FindElementByXPath(SubjectText).Text;
        }
    }
}
