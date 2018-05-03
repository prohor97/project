using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumWebDriver
{
    public class HomePage : BasePageSingleton<HomePage, HomePageMap, HomePageValidator>
    {
        private string url = @"http://www.bbc.com/";

        private HomePage() {}

        public override void Navigate(string url)
        {
            base.Navigate(this.url);
        }

        public void AssertUrl()
        {
            Assert.IsTrue(Driver.Browser.Url.Contains(url));
        }

        public void AssertAllElementsIsVisible()
        {
            Assert.IsTrue(this.Map.SearchField.Displayed);
            Assert.IsTrue(this.Map.SearchButton.Displayed);
        }

        public void ClickSearchButton()
        {
            this.Map.SearchButton.Click();
        }

        public void InputInSearchField(string searchQuery)
        {
            this.Map.SearchField.SendKeys(searchQuery);
        }

        public void ClearSearchField()
        {
            this.Map.SearchField.Clear();
        }
    }
}
