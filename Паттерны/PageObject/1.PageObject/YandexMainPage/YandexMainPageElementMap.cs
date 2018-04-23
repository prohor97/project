using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _1.PageObject
{
    class YandexMainPageElementMap
    {
        private readonly IWebDriver browser;

        public YandexMainPageElementMap(IWebDriver browser)
        {
            this.browser = browser;
        }

        public IWebElement GoButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//a[@class='button2 button2_size_mail-big button2_theme_mail-white button2_type_link HeadBanner-Button HeadBanner-Button-Enter with-shadow']"));
            }
        }
    }
}
