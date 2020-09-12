using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace XeroTechAssessment.StepDefinitions
{
    [Binding]
    public sealed class XeroPortalStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;



        public XeroPortalStepDefinitions(ScenarioContext scenarioContext, IWebDriver driver)
        {
            _scenarioContext = scenarioContext;
            _driver = driver;
        }

        [Given(@"I logon to Xero")]
        public void GivenILogonToXero()
        {
            _driver.Navigate().GoToUrl("https://login.xero.com/identity/user/login/");
        }

        [Then(@"I am happy")]
        public void ThenIAmHappy()
        {
            //double check pipeline
            Assert.IsTrue(true);
        }

    }
}
