using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroTechAssessment.PageObjects
{
    public class AddBankAccountsPage
    {
        private readonly IWebDriver _driver;
        public AddBankAccountsPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement ANZ
        {
            get
            {
                return this._driver.FindElement(By.XPath("//li[contains(text(),'ANZ')]"));
            }
        }

        public IWebElement accountName
        {
            get
            {
                return this._driver.FindElement(By.XPath("//input[@id='accountname-1037-inputEl']"));
            }
        }

        public IWebElement accountType
        {
            get
            {
                return this._driver.FindElement(By.XPath("//input[@id='accounttype-1039-inputEl']"));
            }
        }

        public IWebElement selectfromAccountTypes
        {
            get
            {
                return this._driver.FindElement(By.XPath("//input[@role='combobox']"));
            }
        }


        public IWebElement everydayAccountType
        {
            get
            {
                return this._driver.FindElement(By.XPath("//li[contains(text(),'Everyday')]"));
            }
        }

        public IWebElement accountNumber
        {
            get
            {
                return this._driver.FindElement(By.XPath("//input[@id='accountnumber-1068-inputEl']"));
            }
        }

        public IWebElement continueButton
        {
            get
            {
                return this._driver.FindElement(By.XPath("//a[@data-automationid='continueButton']"));
            }
        }

        public void SelectANZ()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            wait.Until(_driver => _driver.FindElement(By.XPath("//li[contains(text(),'ANZ')]")));
            ANZ.Click();
        }

        public void SelectEverydayAccount()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            selectfromAccountTypes.Click();
             everydayAccountType.Click();
        }

        public void EnterAccountName(string name)
        {
            accountName.SendKeys(name);
        }

        public void EnterAccountNumber(string number)
        {
            accountNumber.SendKeys(number);
        }

        public void ClickContinueButton()
        {
            continueButton.Click();
        }
    }
}
