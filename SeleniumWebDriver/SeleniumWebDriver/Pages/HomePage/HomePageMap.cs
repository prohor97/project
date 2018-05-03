using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public class HomePageMap : BasePageElementMap
    {
        public IWebElement SearchField
        {
            get { return this.browser.FindElement(By.CssSelector("#orb-search-q")); }
        }

        public IWebElement SearchButton
        {
            get { return this.browser.FindElement(By.CssSelector("#orb-search-button")); }
        }
    }
}
