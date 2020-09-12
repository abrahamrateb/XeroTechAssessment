using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace XeroTechAssessment.Hooks
{
    [Binding]
    public sealed class XeroHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private IWebDriver _driver;
        private readonly IObjectContainer _objectContainer;
                
        public XeroHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
