using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _1.PageObject
{
    class YandexMailBoxElementMap
    {
        private readonly IWebDriver browser;

        public YandexMailBoxElementMap(IWebDriver browser)
        {
            this.browser = browser;
        }

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

        public IWebElement SendMessegeButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//button[@class='nb-button _nb-large-action-button _init js-editor-tabfocus-next js-send nb-group-start ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only']"));
            }
        }

        public IWebElement ToField
        {
            get
            {
                return this.browser.FindElement(By.XPath("//div[@class='mail-Compose-Field-Caption mail-Compose-Field-Caption_link js-field-caption']"));
            }
        }

        public IWebElement AttachButton
        {
            get
            {
                return this.browser.FindElement(By.ClassName("cke_toolgroup"));
            }
        }
    }
}
