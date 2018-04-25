using NUnit.Framework;

namespace PageObject
{
    public class SignInPage : BasePage<SignInPageMap, SignInPageValidator>
    {
        public SignInPage()
            : base("https://passport.yandex.by/auth?from=mail&origin=hostroot_homer_auth_v3_by&retpath=https%3A%2F%2Fmail.yandex.by%2F&backpath=https%3A%2F%2Fmail.yandex.by%3Fnoretpath%3D1")
        {
        }

        public void AssertUrl()
        {
            Assert.IsTrue(Driver.Browser.Url.Contains(url));
        }

        public void AssertAllElementsIsVisible()
        {
            Assert.IsTrue(this.Map.LoginField.Displayed);
            Assert.IsTrue(this.Map.PasswordField.Displayed);
            Assert.IsTrue(this.Map.AutorizationButton.Displayed);
        }

        public void Autorization(string login, string password)
        {
            this.Map.LoginField.Clear();
            this.Map.LoginField.SendKeys(login);
            this.Map.PasswordField.Clear();
            this.Map.PasswordField.SendKeys(password);
            this.Map.AutorizationButton.Click();
        }
    }
}
