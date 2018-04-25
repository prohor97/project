using OpenQA.Selenium;

namespace Singleton
{
    public class MailBoxPageMap : BasePageElementMap
    {
        public IWebElement UserName
        {
            get
            {
                return this.browser.FindElement(By.ClassName("mail-User-Name"));
            }
        }

        public IWebElement WriteMessegeButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//a[@class='mail-ComposeButton js-left-col-toolbar-compose']"));
            }
        }
    }
}
