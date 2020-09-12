using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroTechAssessment.PageObjects
{
    public class DashboardPage
    {
        private readonly IWebDriver _driver;
        public DashboardPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement businessBankAccountLink
        {
            get
            {
                return this._driver.FindElement(By.XPath("//h3[@class='xui-panel--heading xui-text-panelheading xui-u-flex-col xui-u-flex-grow xdash-WidgetHeader__widget-header--description___13GyL']"));
            }
        }

        public void ClickBankAccountLink()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            wait.Until(_driver => _driver.FindElement(By.XPath("//h3[@class='xui-panel--heading xui-text-panelheading xui-u-flex-col xui-u-flex-grow xdash-WidgetHeader__widget-header--description___13GyL']")));
            businessBankAccountLink.Click();
        }
    }
}
