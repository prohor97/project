using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace _1.PageObject
{
    class YandexMailBoxValidator
    {
        private readonly IWebDriver browser;
 
        public YandexMailBoxValidator(IWebDriver browser)
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

        public void VerifyYourUserName(string userName)
        {
            var text = this.Map.UserName.Text;
            Assert.IsTrue(text.Contains(userName));
        }
    }
}
