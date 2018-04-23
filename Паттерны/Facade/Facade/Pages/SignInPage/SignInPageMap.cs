using OpenQA.Selenium;

namespace Facade
{
    public class SignInPageMap : BasePageElementMap
    {
        public IWebElement LoginField
        {
            get
            {
                return this.browser.FindElement(By.Name("login"));
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                return this.browser.FindElement(By.Name("passwd"));
            }
        }

        public IWebElement AutorizationButton
        {
            get
            {
                return this.browser.FindElement(By.ClassName("passport-Button-Content"));
            }
        }
    }
}
