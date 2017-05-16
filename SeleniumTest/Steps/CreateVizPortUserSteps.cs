using SeleniumTest.Utilities;
using SeleniumTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using NUnit;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Steps
{
    [Binding]
    class CreateVizPortUserSteps
    {
        private DriverPoC driver = new DriverPoC();
        private CreateVizPortUserPage createVizPortUserPage = new CreateVizPortUserPage();

        public CreateVizPortUserSteps()
        {
            PageFactory.InitElements(driver, createVizPortUserPage);
        }

        [When(@"I feel all fields from table")]
        public void WhenIFeelAllMandatoryFieldsFromTable(Table table)
        {
            var item = table.CreateInstance<CreateVizUserTableToFill>();
            item.Email = System.DateTime.Now.ToString("MM.dd.hh.mm.ss") + item.Email; //Generate random unic prefix for email
            this.generatedEmail = item.Email;
            this.userFirstName = item.FirstName;
            this.userSurname = item.Surname;
            FillCreateVizUserTable(item);
        }

        string generatedEmail;
        string userFirstName;
        string userSurname;

        private void FillCreateVizUserTable(CreateVizUserTableToFill item)
        {
            createVizPortUserPage.FirstNameInputSendNewKeys(item.FirstName);
            createVizPortUserPage.SurnameInputSendNewKeys(item.Surname);
            createVizPortUserPage.EmailInputSendNewKeys(item.Email);
            createVizPortUserPage.PhoneNumberSendNewKeys(item.InternationalCode, item.Area, item.PhoneNumber);
        }

        [When(@"I click '(.*)' button")]
        public void WhenIClickButton(string value)
        {
            switch (value.ToLower())
            {
                case "create":
                    createVizPortUserPage.CreateButtonClick();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }

        }

        [Then(@"I see that user has been successfully created")]
        public void ThenISeeThatUserHasBeenSuccessfullyCreated()
        {
            string expectedMessage = Dictionary.VizDictionary["userCreated1"]+ this.userFirstName + " " + this.userSurname + " " + "(" + this.generatedEmail + Dictionary.VizDictionary["userCreated2"];
            string actualMessage = createVizPortUserPage.UserCreatedMessage.Text;
            Assert.AreEqual(expectedMessage,actualMessage);
        }


    }
}
