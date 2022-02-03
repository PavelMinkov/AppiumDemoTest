using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.PageObjects
{
    public class ComposePO : BasePO
    {
        public ComposePO(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string ComposeBTN = "compose_button";
        private readonly string ToText = "//android.view.ViewGroup/android.widget.EditText";
        private readonly string ListPeople = "peoplekit_listview_flattened_row";
        private readonly string TypeSubject = "subject";
        private readonly string TypeLetter = "//android.webkit.WebView/android.widget.EditText";
        private readonly string SendBTN = "send";

        public ComposePO ClickComposeBTN()
        {
            driver.FindElementById(ComposeBTN).Click();
            return this;
        }

        public ComposePO EnterToText(string mail)
        {
            driver.FindElementByXPath(ToText).SendKeys(mail);
            driver.FindElementById(ListPeople).Click();
            return this;
        }
        public ComposePO EnterSubject(string subject)
        {
            driver.FindElementById(TypeSubject).SendKeys(subject);
            return this;
        }

        public ComposePO EnterTextLetter(string text)
        {
            driver.FindElementByXPath(TypeLetter).SendKeys(text);
            return this;
        }

        public ComposePO ClisckSendBTN()
        {
            driver.FindElementById(SendBTN).Click();
            return this;
        }

    }
}
