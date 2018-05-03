using NUnit.Framework;

namespace SeleniumWebDriver
{
    [TestFixture(BrowserTypes.Chrome)]
    [TestFixture(BrowserTypes.Firefox)]
    [TestFixture(BrowserTypes.InternetExplorer)]
    public class BBCTests
    {
        private BrowserTypes browser;

        public BBCTests(BrowserTypes browser)
        {
            this.browser = browser;
        }

        [SetUp]
        public void SetupTest()
        {
            Driver.StartBrowser(browser, 50);
        }

        [TearDown]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestCase("qqq")]
        public void Tests_SearchAndTransactionToTheFirstLink(string queryString)
        {
            string urlLink;
            string titleLink;

            HomePage.Instance.Navigate("");
            HomePage.Instance.AssertUrl();
            HomePage.Instance.AssertAllElementsIsVisible();
            HomePage.Instance.InputInSearchField(queryString);
            HomePage.Instance.ClickSearchButton();

            ResultPage.Instance.AssertUrl(queryString);
            ResultPage.Instance.AssertAllElementsIsVisible(queryString);
            urlLink = ResultPage.Instance.LinkToTheFirstElementOfTheList(out titleLink);
            ResultPage.Instance.ClickToTheFirstElementOfTheList();

            FinalPage.Instance.AssertUrl(urlLink);
            FinalPage.Instance.AssertTitle(titleLink);
        }
    }
}
