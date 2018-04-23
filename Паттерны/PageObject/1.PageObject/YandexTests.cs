using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace _1.PageObject
{
    [TestClass]
    class YandexTests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        
        YandexMainPage yandexMainPage;
        YandexAutorizationPage yandexAutorizationPage;
        YandexMailBox yandexMailBox;

        [OneTimeSetUp]
        public void SetupTest()
        {
            this.Driver = new FirefoxDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(70));
            this.yandexMainPage = new YandexMainPage(this.Driver);
            this.yandexAutorizationPage = new YandexAutorizationPage(this.Driver);
            this.yandexMailBox = new YandexMailBox(this.Driver);
        }

        [SetUp]
        public void SetupTests()
        {     
            yandexMainPage.Navigate();
            yandexMainPage.AssertAllElementsIsVisible();
            yandexMainPage.ClickGoButton();
        }

        [OneTimeTearDown]
        public void TeardownTest()
        {
            yandexMainPage.ClearCookie();
            this.Driver.Quit();
        }

        [TestCase("prohorzyazyulya", "Prohor1997")]
        public void Autorization(string login, string password)
        {
            yandexAutorizationPage.AssertUrl();
            yandexAutorizationPage.AssertAllElementsIsVisible();
            yandexAutorizationPage.Autorization(login, password);
            yandexMailBox.AssertUrlMailBox();
            yandexMailBox.AssertAllElementsIsVisible();
            yandexMailBox.Validate().VerifyYourUserName(login);
            yandexMailBox.ClickButtonWriteMessegeButton();
            yandexMailBox.AssertUrlWriteMessage();
            yandexMailBox.AssertAllElementsIsVisibleWriteMessage();
        }
    }
}
