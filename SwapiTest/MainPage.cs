using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SwapiTest
{
    public class MainPage
    {
        IWebDriver driver;
        public MainPage(IWebDriver _driver)
            {

                driver = _driver;

            }

        public IWebElement TextField => driver.FindElement(By.Id("interactive"));
        public IWebElement RequestButton => driver.FindElement(By.XPath("//span[@class='input-group-btn']/button[@class='btn btn-primary']"));
        public IWebElement ResultBox => driver.FindElement(By.Id("interactive_output"));

        public void SetSearchItem(string searchItem)
        {
            TextField.SendKeys(searchItem);
        }

        public void Search()
        {
            RequestButton.Click();
        }
        
        public SpaceShip GetData()
        {
            SpaceShip output = JsonConvert.DeserializeObject<SpaceShip>(ResultBox.Text);
            return output;
        }
       
    }
}
