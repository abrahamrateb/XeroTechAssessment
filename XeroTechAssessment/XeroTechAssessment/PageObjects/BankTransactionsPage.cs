using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroTechAssessment.PageObjects
{
    public class BankTransactionsPage
    {
        private readonly IWebDriver _driver;
        public BankTransactionsPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement bankAccountLink
        {
            get
            {
                return this._driver.FindElement(By.XPath("//a[contains(text(),'Bank Accounts')]"));
            }
        }

        public void ClickBankAccountLink()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            wait.Until(_driver => _driver.FindElement(By.XPath("//a[contains(text(),'Bank Accounts')]")));
            bankAccountLink.Click();
        }
    }
}
