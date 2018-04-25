using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton
{
    [TestClass]
    public class YandexSingletonTests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void AutorizationAndCheckedUserName()
        {
            string login = "prohorzyazyulya";
            string password = "Prohor1997";

            MainPage.Instance.Navigate("");

            MainPage.Instance.AssertUrl();
            MainPage.Instance.AssertAllElementsIsVisible();
            MainPage.Instance.ClickGoButton();

            SignInPage.Instance.AssertUrl();
            SignInPage.Instance.AssertAllElementsIsVisible();
            SignInPage.Instance.Autorization(login, password);

            MailBoxPage.Instance.AssertUrl();
            MailBoxPage.Instance.AssertAllElementsIsVisible();
            MailBoxPage.Instance.VerifyYourUserName(login);
            MailBoxPage.Instance.ClickButtonWriteMessegeButton();

            CreatingMessagePage.Instance.AssertUrl();
            CreatingMessagePage.Instance.AssertAllElementsIsVisibleWriteMessage();
        }
    }
}
