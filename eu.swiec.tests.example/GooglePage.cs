using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu.swiec.tests.example
{
    class GooglePage
    {
        IWebDriver driver;
        IWebElement searchInput;
        IWebElement searchBtn;

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public IWebElement SearchInput { get => searchInput ?? (searchInput = driver.FindElement(By.Id("lst-ib"))); set => searchInput = value; }
        public IWebElement SearchBtn { get => searchBtn ?? (searchBtn = driver.FindElement(By.Name("btnK"))); set => searchBtn = value; }

        internal GooglePage openPage()
        {
            driver.Navigate().GoToUrl("http:\\www.google.com");
            return this;
        }

        internal GooglePage searchForQuery(string query)
        {
            SearchInput.Click();
            SearchInput.SendKeys(query);
            SearchInput.SendKeys(Keys.Enter);
            return this;
        }

    }
}
