using OpenQA.Selenium;

namespace Singleton
{
    public class MainPageMap : BasePageElementMap
    {
        public IWebElement GoButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//a[@class='button2 button2_size_mail-big button2_theme_mail-white button2_type_link HeadBanner-Button HeadBanner-Button-Enter with-shadow']"));
            }
        }
    }
}
