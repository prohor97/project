using NUnit.Framework;

namespace Facade
{
    public class CreatingMessagePage : BasePage<CreatingMessagePageMap, CreatingMessagePageValidation>
    {
        public CreatingMessagePage()
            : base("https://mail.yandex.by/?uid=641042106&login=prohorzyazyulya#compose")
        {
        }

        public void AssertUrl()
        {
            Assert.IsTrue(Driver.Browser.Url.Contains(url));
        }

        public void AssertAllElementsIsVisibleWriteMessage()
        {
            Assert.IsTrue(this.Map.SendMessegeButton.Displayed);
            Assert.IsTrue(this.Map.ToField.Displayed);
            Assert.IsTrue(this.Map.AttachButton.Displayed);
        }
    }
}
