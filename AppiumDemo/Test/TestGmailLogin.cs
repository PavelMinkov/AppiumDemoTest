using AppiumDemo.BusinessObjects;
using AppiumDemo.Driver;
using AppiumDemo.Utils;
using NUnit.Framework;

namespace AppiumDemo
{
    public class Tests
    {
        private GmailBO gmailBO;
        private readonly string recipient = "minkovapolina21@gmail.com";
        private readonly string subject = "Test Subject " + DataUtil.GetSystemCurrentDate();
        private readonly string text = "Test Text " + DataUtil.GetSystemCurrentDate();

        [SetUp]
        public void Setup()
        {
            gmailBO = new GmailBO(AndroidDriverSingleton.getDriver());
        }

        [Test]
        public void Test1()
        {
            gmailBO.SkipInitialPages().SendLetter(recipient, subject, text);
            Assert.AreEqual(gmailBO.GetSubjectText(), subject);
            gmailBO.DeleteLetter();
            Assert.AreNotEqual(gmailBO.GetSubjectText(), subject);
        }

        [TearDown]
        public void CleanUp()
        {
            AndroidDriverSingleton.quitDriver();
        }

    }
}