using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation_bootcamp
{
    public class Lecture_11
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [Category("Lecture_11")]
        public void Exercise1()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.CssSelector("button[title='Toggle']")).Click();
            driver.FindElement(By.CssSelector("label[for='tree-node-documents']")).Click();
            driver.FindElement(By.CssSelector("label[for='tree-node-downloads']")).Click();
            Thread.Sleep(500);
        }

        [Test]
        [Category("Lecture_11")]
        public void Exercise2()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.CssSelector("label[for='yesRadio']")).Click();
            driver.FindElement(By.CssSelector("label[for='impressiveRadio']")).Click();
            Thread.Sleep(500);
        }

        [Test]
        [Category("Lecture_11")]
        public void Exercise3()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            driver.Manage().Window.Maximize();

            string email = driver.FindElement(
                By.XPath("//*[@id='app']/div/div/div[2]/div[2]/div[1]/div[3]/div[1]/div[2]/div[1]/div/div[4]")).Text;

            Assert.AreEqual(email, "cierra@example.com");


        }

        [Test]
        [Category("Lecture_11")]
        public void Exercise4()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/select-menu");
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://demoqa.com/select-menu");

            driver.FindElement(By.Id("withOptGroup")).Click();
            driver.FindElement(By.Id("react-select-2-option-0-1")).Click();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
