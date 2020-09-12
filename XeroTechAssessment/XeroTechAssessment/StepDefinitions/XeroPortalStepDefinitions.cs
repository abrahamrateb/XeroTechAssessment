using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using XeroTechAssessment.PageObjects;

namespace XeroTechAssessment.StepDefinitions
{
    [Binding]
    public sealed class XeroPortalStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        public string loginUserName = "abrahamrateb@gmail.com";
        public string loginPassword = "xero1234";
        public LoginPage loginPage;
        public DashboardPage dashboardPage;
        public BankTransactionsPage bankTransactionsPage;
        public BankAccountsPage bankAccountsPage;
        public AddBankAccountsPage addBankAccountsPage;

        public XeroPortalStepDefinitions(ScenarioContext scenarioContext, IWebDriver driver)
        {
            _scenarioContext = scenarioContext;
            _driver = driver;
            loginPage = new LoginPage(_driver);
            dashboardPage = new DashboardPage(_driver);
            bankTransactionsPage = new BankTransactionsPage(_driver);
            bankAccountsPage = new BankAccountsPage(_driver);
            addBankAccountsPage = new AddBankAccountsPage(_driver);
        }

        [Given(@"I logon to Xero")]
        public void GivenILogonToXero()
        {
            _driver.Navigate().GoToUrl("https://login.xero.com/identity/user/login/");
            loginPage.LoginWith(loginUserName, loginPassword);
        }

        [Then(@"I am happy")]
        public void ThenIAmHappy()
        {
            Assert.IsTrue(true);
        }

        [When(@"I click the Business Bank Account Link")]
        public void WhenIClickTheBusinessBankAccountLink()
        {
            dashboardPage.ClickBankAccountLink();
        }

        [When(@"I click the Bank Account link")]
        public void WhenIClickTheBankAccountLink()
        {
            bankTransactionsPage.ClickBankAccountLink();
        }

        [When(@"I click the Bank Account button")]
        public void WhenIClickTheBankAccountButton()
        {
            bankAccountsPage.ClickAddAccountButton();
        }

        [When(@"I select ANZ")]
        public void WhenISelectANZ()
        {
            addBankAccountsPage.SelectANZ();
        }

        [When(@"I select Everyday Account")]
        public void WhenISelectEverydayAccount()
        {
            addBankAccountsPage.SelectEverydayAccount();
        }

        [When(@"I enter account name '(.*)'")]
        public void WhenIEnterAccountName(string accountName)
        {
            addBankAccountsPage.EnterAccountName(accountName);
        }

        [When(@"I enter account number (.*)")]
        public void WhenIEnterAccountNumber(string accountNumber)
        {
            addBankAccountsPage.EnterAccountNumber(accountNumber);
        }

        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            addBankAccountsPage.ClickContinueButton();
        }

        [Then(@"account name '(.*)' with account number '(.*)' is created")]
        public void ThenAccountNameWithAccountNumberIsCreated(string accountName, string accountNumber)
        {
            Assert.IsTrue(bankAccountsPage.AssertAccountNameExist(accountName), "The account name: {0} does not exist", accountName);
            Assert.IsTrue(bankAccountsPage.AssertAccountNumberExist(accountNumber), "The account number: {0} does not exist", accountNumber);
        }

    }
}
