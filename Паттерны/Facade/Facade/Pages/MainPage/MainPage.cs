using NUnit.Framework;

namespace Facade
{
    public class MainPage : BasePage<MainPageMap, MainPageValidator>
    {
        public MainPage()
            : base("https://mail.yandex.by/")
        {
        }

        public override void Navigate(string part)
        {
            base.Navigate(part);
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
