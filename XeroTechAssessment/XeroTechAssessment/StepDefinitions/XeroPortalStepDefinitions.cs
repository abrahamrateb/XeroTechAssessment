using NUnit.Framework;
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

        public XeroPortalStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I logon to Xero")]
        public void GivenILogonToXero()
        {
            Console.WriteLine("I logon to Xero");
        }

        [Then(@"I am happy")]
        public void ThenIAmHappy()
        {
            //double check pipeline
            Assert.IsTrue(true);
        }

    }
}
