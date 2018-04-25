using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageObject
{
    [TestClass]
    public class YandexTests
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
            
            MainPage mainPage = new MainPage();
            SignInPage signInPage = new SignInPage();
            MailBoxPage mailBoxPage = new MailBoxPage();
            CreatingMessagePage creatingMessagePage = new CreatingMessagePage();
            
            string login = "prohorzyazyulya";
            string password = "Prohor1997";

            mainPage.Navigate("");

            mainPage.AssertUrl();
            mainPage.AssertAllElementsIsVisible();
            mainPage.ClickGoButton();

            signInPage.AssertUrl();
            signInPage.AssertAllElementsIsVisible();
            signInPage.Autorization(login, password);

            mailBoxPage.AssertUrl();
            mailBoxPage.AssertAllElementsIsVisible();
            mailBoxPage.VerifyYourUserName(login);
            mailBoxPage.ClickButtonWriteMessegeButton();

            creatingMessagePage.AssertUrl();
            creatingMessagePage.AssertAllElementsIsVisibleWriteMessage();
        }
    }
}
