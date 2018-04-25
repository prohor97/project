using OpenQA.Selenium;

namespace PageObject
{
    public class BasePageElementMap
    {
        protected IWebDriver browser;
 
        public BasePageElementMap()
        {
            this.browser = Driver.Browser;
        }
    }
}
