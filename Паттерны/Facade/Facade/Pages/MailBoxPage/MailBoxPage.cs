using NUnit.Framework;

namespace Facade
{
    public class MailBoxPage : BasePage<MailBoxPageMap, MailBoxPageValidation>
    {
        public MailBoxPage()
            : base("https://mail.yandex.by/?uid=641042106&login=prohorzyazyulya#inbox")
        {
        }

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
    }
}
