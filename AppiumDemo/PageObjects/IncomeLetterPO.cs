using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.PageObjects
{
    public class IncomeLetterPO : BasePO
    {
        public IncomeLetterPO(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string ImageViewBTN = "//android.view.ViewGroup[1]/android.widget.ImageView[1]";
        private readonly string DeleteBTN = "delete";

        public IncomeLetterPO ClickImageViewBTN()
        {
            driver.FindElementByXPath(ImageViewBTN).Click();
            return this;
        }
        public IncomeLetterPO ClickDeleteBTN()
        {
            driver.FindElementById(DeleteBTN).Click();
            return this;
        }

    }
}
