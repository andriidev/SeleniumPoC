using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class LoginPage
    {
        //Input fields
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_username")]
        public IWebElement UsernameInput { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_password")]
        public IWebElement PasswordInput { get; set; }

        //Labels, text
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_errorMessageLabel_errorMessageLabel")]
        public IWebElement LoginErrorMessage { get; set; }

        //Buttons
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_SUBMIT")]
        public IWebElement LoginButton { get; set; }

        //Actions
        public void UsernameInputSendNewKeys(string userName)
        {
            UsernameInput.Clear();
            UsernameInput.SendKeys(userName);
        }
        public void PasswordSendNewKeys(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }
        public void LoginButtonClick()
        {
            LoginButton.Click();
        }

    }
}
