using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace SwapiTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;


        [TestInitialize]
        public void TestInit()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://swapi.co/");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Close();
            driver.Dispose();
        }

        [TestMethod]
        public void TestMethod1()
        {
            IWebElement textField = driver.FindElement(By.Id("interactive"));
            var starShipsSearchSearch = "starships";
            textField.Clear();
            textField.SendKeys(starShipsSearchSearch);
              

        }
    }
}
