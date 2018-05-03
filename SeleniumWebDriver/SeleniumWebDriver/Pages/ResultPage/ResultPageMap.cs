using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public class ResultPageMap : BasePageElementMap
    {
        public IWebElement FirstLink
        {
            get { return this.browser.FindElement(By.CssSelector(".search-results.results li:first-child h1 a")); }
        }

        public IWebElement ListOfResult
        {
            get { return this.browser.FindElement(By.CssSelector(".search-results.results")); }
        }

        public IWebElement BigSearchField
        {
            get { return this.browser.FindElement(By.CssSelector("#se-searchbox-input-field")); }
        }
    }
}
