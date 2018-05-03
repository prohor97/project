using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SeleniumWebDriver
{
    public class ResultPage : BasePageSingleton<ResultPage, ResultPageMap, ResultPageValidator>
    {
        private ResultPage() { }

        public void AssertUrl(string searchQuery)
        {
            string url = @"https://www.bbc.co.uk/search?q=" + searchQuery;
            Assert.IsTrue(Driver.Browser.Url.Contains(url));
        }

        public void AssertAllElementsIsVisible(string searchQuery)
        {
            var text = this.Map.BigSearchField.GetAttribute("value");

            Assert.IsTrue(this.Map.ListOfResult.Displayed);
            Assert.IsTrue(this.Map.FirstLink.Displayed);
            Assert.IsTrue(this.Map.BigSearchField.Displayed);
            Assert.IsTrue(text.Contains(searchQuery));
        }

        public string LinkToTheFirstElementOfTheList(out string titleLink)
        {
            var text = this.Map.FirstLink.GetAttribute("href");
            titleLink = this.Map.FirstLink.Text;
            return text;
        }

        public void ClickToTheFirstElementOfTheList()
        {
            this.Map.FirstLink.Click();
        }
    }
}
