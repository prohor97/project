using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace _1.PageObject
{
    class YandexAutorizationPage
    {
        private readonly IWebDriver browser;
        private readonly string url = @"https://passport.yandex.by/auth?from=mail&origin=hostroot_homer_auth_v3_by&retpath=https%3A%2F%2Fmail.yandex.by%2F&backpath=https%3A%2F%2Fmail.yandex.by%3Fnoretpath%3D1";

        public YandexAutorizationPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected YandexAutorizationPageElementMap Map
        {
            get
            {
                return new YandexAutorizationPageElementMap(this.browser);
            }
        }

        public void AssertUrl()
        {
            Assert.IsTrue(browser.Url.Contains(url));
        }

        public void AssertAllElementsIsVisible()
        {
            Assert.IsTrue(this.Map.LoginField.Displayed);
            Assert.IsTrue(this.Map.PasswordField.Displayed);
            Assert.IsTrue(this.Map.AutorizationButton.Displayed);
        }

        public void Autorization(string login, string password)
        {
            this.Map.LoginField.Clear();
            this.Map.LoginField.SendKeys(login);
            this.Map.PasswordField.Clear();
            this.Map.PasswordField.SendKeys(password);
            this.Map.AutorizationButton.Click();
        }
    }
}
