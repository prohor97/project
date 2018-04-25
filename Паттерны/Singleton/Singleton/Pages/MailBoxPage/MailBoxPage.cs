using NUnit.Framework;

namespace Singleton
{
    public class MailBoxPage : BasePageSingleton<MailBoxPage, MailBoxPageMap, MailBoxPageValidation>
    {
        private string url = @"https://mail.yandex.by/?uid=641042106&login=prohorzyazyulya#inbox";

        private MailBoxPage() { }

        public void AssertUrl()
        {
            Assert.IsTrue(Driver.Browser.Url.Contains(url));
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

        public void VerifyYourUserName(string userName)
        {
            var text = this.Map.UserName.Text;
            Assert.IsTrue(text.Contains(userName));
        }
    }
}
