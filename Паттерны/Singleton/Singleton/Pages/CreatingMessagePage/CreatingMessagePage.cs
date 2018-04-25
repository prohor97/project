using NUnit.Framework;

namespace Singleton
{
    public class CreatingMessagePage : BasePageSingleton<CreatingMessagePage, CreatingMessagePageMap, CreatingMessagePageValidation>
    {
        private string url = @"https://mail.yandex.by/?uid=641042106&login=prohorzyazyulya#compose";

        private CreatingMessagePage() { }

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
