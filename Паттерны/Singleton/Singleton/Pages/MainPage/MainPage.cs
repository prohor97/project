using NUnit.Framework;

namespace Singleton
{
    public class MainPage : BasePageSingleton<MainPage, MainPageMap, MainPageValidator>
    {
        private string url = @"https://mail.yandex.by/";

        private MainPage() { }

        public override void Navigate(string url)
        {
            base.Navigate(this.url);
        }

        public void AssertUrl()
        {
            Assert.IsTrue(Driver.Browser.Url.Contains(url));
        }

        public void ClickGoButton()
        {
            this.Map.GoButton.Click();
        }

        public void AssertAllElementsIsVisible()
        {
            Assert.IsTrue(this.Map.GoButton.Displayed);
        }
    }
}
