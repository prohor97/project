using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace _1.PageObject
{
    class YandexMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = @"https://mail.yandex.by/";

        public YandexMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected YandexMainPageElementMap Map
        {
            get
            {
                return new YandexMainPageElementMap(this.browser);
            }
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
        }

        public void ClickGoButton()
        {
            this.Map.GoButton.Click();
        }

        public void AssertAllElementsIsVisible()
        {
            Assert.IsTrue(this.Map.GoButton.Displayed);
        }

        public void ClearCookie()
        {
            this.browser.Manage().Cookies.DeleteAllCookies();
        }
    }
}
