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
    static class Browser
    {
        public static IWebDriver Driver => new ChromeDriver();


    }
}
