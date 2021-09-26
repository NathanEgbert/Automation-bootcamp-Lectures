using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;

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

            IWebElement dropdown = driver.FindElement(By.Id("withOptGroup"));
            dropdown.Click();

            //TODO: Fix me
            SelectElement menu = new SelectElement(driver.FindElement(By.CssSelector(" div[class='css-2613qy-menu']")));
            menu.SelectByIndex(2);
    



            Thread.Sleep(100);
           

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
