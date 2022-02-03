using AppiumDemo.PageObjects;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.BusinessObjects
{
    public class GmailBO
    {
        private readonly InitialPO initialPage;
        private readonly ComposePO composePO;
        private readonly IncomeLetterPO incomeLetterPO;

        public GmailBO(AppiumDriver<AndroidElement> driver)
        {
            initialPage = new InitialPO(driver);
            composePO = new ComposePO(driver);
            incomeLetterPO = new IncomeLetterPO(driver);
        }

        public GmailBO SkipInitialPages()
        {
            initialPage.ClickGotItBTN().ClickTakeMeToGmailBTN().ClickGotItPopUpBTN();
            return this;
        }
        public GmailBO SendLetter(string recipient, string subject, string text)
        {
            composePO.ClickComposeBTN().EnterToText(recipient).EnterSubject(subject).EnterTextLetter(text).ClisckSendBTN();
            initialPage.ClickNavigationBTN().ClickPrimaryBTN();
            return this;
        }
        public GmailBO DeleteLetter()
        {
            incomeLetterPO.ClickImageViewBTN().ClickDeleteBTN();
            initialPage.ClickNavigationBTN().ClickPrimaryBTN();
            return this;
        }

        public string GetSubjectText()
        {
            return initialPage.GetSubjectText();
        }

    }
}
