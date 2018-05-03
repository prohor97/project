using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public class FinalPageMap : BasePageElementMap
    {
        public IWebElement Title
        {
            get { return this.browser.FindElement(By.TagName("title")); }
        }
    }
}
