using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class CreateVizPortUserPage
    {
        //Input fields
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_userFirstnameTextBox")]
        public IWebElement FirstNameInput { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_userSurnameTextBox")]
        public IWebElement SurnameInput { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_emailAddressTextBox")]
        public IWebElement EmailInput { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_userTelephoneControl_internationalCodeTextBox")]
        public IWebElement PhNumInternInput { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_userTelephoneControl_areaCodeTextBox")]
        public IWebElement PhNumAreaCodeInput { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_userTelephoneControl_phoneNumberTextBox")]
        public IWebElement PhNumberInput { get; set; }

        //Labels, text
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_descriptionLabel")]
        public IWebElement UserCreatedMessage { get; set; }
        
        //Buttons
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder_createUserButton")]
        public IWebElement CreateButton  { get; set; }

        //Actions
        public void FirstNameInputSendNewKeys(string fName)
        {
            FirstNameInput.Clear();
            FirstNameInput.SendKeys(fName);
        }
        public void SurnameInputSendNewKeys(string sName)
        {
            SurnameInput.Clear();
            SurnameInput.SendKeys(sName);
        }
        public void EmailInputSendNewKeys(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
        }
        public void PhoneNumberSendNewKeys(string international, string area, string phoneN)
        {
            PhNumInternInput.Clear();
            PhNumInternInput.SendKeys(international);
            PhNumAreaCodeInput.Clear();
            PhNumAreaCodeInput.SendKeys(area);
            PhNumberInput.Clear();
            PhNumberInput.SendKeys(phoneN);

        }
        public void CreateButtonClick()
        {
            CreateButton.Click();
        }
    }
}
