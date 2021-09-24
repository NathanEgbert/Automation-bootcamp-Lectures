using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Automation_bootcamp
{
    public class Lecture_10
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }


        [Test]
        [Category("Lecture_10")]
        public void PrintSearchResults()
        {
            driver.Navigate().GoToUrl("https://www.yahoo.com/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            IWebElement searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ybar-sbq")));
            searchBox.SendKeys("test automation");

            driver.FindElement(By.Id("ybar-search")).Click();

            IWebElement table = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/ol[1]")));
            ReadOnlyCollection<IWebElement> searchElements = table.FindElements(By.TagName("li"));
            for(int i = 1; i< 10; i++)
            {
                Console.WriteLine(searchElements[i]);
            }

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
