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

        public XeroPortalStepDefinitions(ScenarioContext scenarioContext, IWebDriver driver)
        {
            _scenarioContext = scenarioContext;
            _driver = driver;
            loginPage = new LoginPage(_driver);
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

    }
}
