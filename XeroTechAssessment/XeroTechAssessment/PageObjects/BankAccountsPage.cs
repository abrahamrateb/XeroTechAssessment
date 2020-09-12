using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroTechAssessment.PageObjects
{
    public class BankAccountsPage
    {
        private readonly IWebDriver _driver;
        public BankAccountsPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement addBankAccountButton
        {
            get
            {
                return this._driver.FindElement(By.XPath("//a[@id='ext-gen42']"));
            }
        }

        public void ClickAddAccountButton()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            wait.Until(_driver => _driver.FindElement(By.XPath("//a[@id='ext-gen42']")));
            addBankAccountButton.Click();
        }
    }
}
