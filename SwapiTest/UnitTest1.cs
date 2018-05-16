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
        Application app = new Application();

        [TestInitialize]
        public void TestInit()
        {
            
            app.Start("https://swapi.co/");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            app.Close();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            var starShipsSearchSearch = "starships";
            
              

        }
    }
}
