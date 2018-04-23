using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace _1.PageObject
{
    class YandexMailBox
    {
        private readonly IWebDriver browser;
        private readonly string urlMailBox = @"https://mail.yandex.by/?uid=641042106&login=prohorzyazyulya#inbox";
        private readonly string urlWriteMessage = @"https://mail.yandex.by/?uid=641042106&login=prohorzyazyulya#compose";

        public YandexMailBox(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected YandexMailBoxElementMap Map
        {
            get
            {
                return new YandexMailBoxElementMap(this.browser);
            }
        }

        public YandexMailBoxValidator Validate()
        {
            return new YandexMailBoxValidator(this.browser);
        }

        public void AssertUrlMailBox()
        {
            Assert.IsTrue(browser.Url.Contains(urlMailBox));
        }

        public void AssertUrlWriteMessage()
        {
            Assert.IsTrue(browser.Url.Contains(urlWriteMessage));
        }
        
        public void AssertAllElementsIsVisible()
        {
            Assert.IsTrue(this.Map.UserName.Displayed);
            Assert.IsTrue(this.Map.WriteMessegeButton.Displayed);
        }

        public void ClickButtonWriteMessegeButton()
        {
            this.Map.WriteMessegeButton.Click();
        }

        public void AssertAllElementsIsVisibleWriteMessage()
        {
            Assert.IsTrue(this.Map.SendMessegeButton.Displayed);
            Assert.IsTrue(this.Map.ToField.Displayed);
            Assert.IsTrue(this.Map.AttachButton.Displayed);
        }
    }
}
