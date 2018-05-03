using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;


namespace SwapiTest
{
    public class Application
    {
        public IWebDriver driver = Browser.Driver; 
        public Application Start(string url)
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public void Close()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
