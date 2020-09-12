using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroTechAssessment.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement LoginUserName
        {
            get
            {
                return this._driver.FindElement(By.XPath("//input[@data-automationid='Username--input']"));
            }
        }
        public IWebElement LoginPassword
        {
            get
            {
                return this._driver.FindElement(By.XPath("//input[@data-automationid='PassWord--input']"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return this._driver.FindElement(By.XPath("//button[@id='xl-form-submit']"));
            }
        }

        public void EnterUserName(string loginUserName)
        {
            LoginUserName.SendKeys(loginUserName);
        }

        public void EnterUserPassword(string loginPassword)
        {
            LoginPassword.SendKeys(loginPassword);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void LoginWith(string loginUserName, string loginPassword)
        {
            EnterUserName(loginUserName);
            EnterUserPassword(loginPassword);
            ClickLoginButton();
        }
    }
}
