using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_bootcamp
{
    public class Lecture_8
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [Test]
        [Category("Lecture_8")]
        public void ValidateTitle()
        {
            driver.Navigate().GoToUrl("https://boardgamegeek.com/");
            driver.Manage().Window.Maximize();

            IWebElement title = driver.FindElement(By.XPath("//h1[text()='boardgame geek']"));

            Assert.AreEqual(title.Text, "boardgame geek");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
