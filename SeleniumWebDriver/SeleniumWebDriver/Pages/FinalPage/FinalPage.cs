using NUnit.Framework;

namespace SeleniumWebDriver
{
    public class FinalPage : BasePageSingleton<FinalPage, FinalPageMap, FinalPageValidator>
    {
        private FinalPage() { }

        public void AssertUrl(string urlLinl)
        {
            Assert.IsTrue(Driver.Browser.Url.Contains(urlLinl));
        }

        public void AssertTitle(string titleLink)
        {
            Assert.AreEqual(Driver.Browser.Title, titleLink);
        }
    }
}
