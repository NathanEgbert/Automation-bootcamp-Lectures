using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace Automation_bootcamp
{
    public class Lecture_9
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [Test]
        [Category("Lecture_9")]
        public void LocateById()
        {
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");
            driver.Manage().Window.Maximize();

            IWebElement searchBox = driver.FindElement(By.Id("1"));

            Assert.IsTrue(searchBox.Displayed, "true");

        }

        [Test]
        [Category("Lecture_9")]
        public void LocateByXPath()
        {
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");
            driver.Manage().Window.Maximize();

            IWebElement Browse = driver.FindElement(By.XPath("//*[contains(text(), ' Browse ')]"));

            Assert.IsTrue(Browse.Displayed, "true");

        }

        [Test]
        [Category("Lecture_9")]
        public void LocateByCssSelector()
        {
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");
            driver.Manage().Window.Maximize();

            IWebElement Dashboard = driver.FindElement(By.CssSelector("a[id='dashboard']"));

            Assert.IsTrue(Dashboard.Displayed, "true");

        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
