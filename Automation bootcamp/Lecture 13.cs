using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace Automation_bootcamp
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [Category("Lecture_13_Search")]
        public void Search()
        {

            string mySearch = File.ReadAllText(@"C:\Users\nathan.egbert\source\repos\Automation bootcamp\Automation bootcamp\Files\SearchFile.txt");

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement searchBox = driver.FindElement(By.CssSelector("input[title='Search']"));
            searchBox.SendKeys(mySearch);
            searchBox.Click();
        }


        [Test]
        [Category("Lecture_13_RegressionTest")]
        public void ATMediaTest()
        {
            driver.Navigate().GoToUrl("https://agilethought.com/");
            driver.Manage().Window.Maximize();

            IWebElement mediaIcon = driver.FindElement(By.XPath("/html/body/div[4]/div/section[4]/div/div/div[2]/div/div/div[2]/div/div/span[1]/a"));
            Assert.IsTrue(mediaIcon.Displayed, "true");

        }

        [Test]
        [Category("Lecture_13_RegressionTest")]
        public void AmazonSearchTest()
        {
            string mySearch = File.ReadAllText(@"C:\Users\nathan.egbert\source\repos\Automation bootcamp\Automation bootcamp\Files\AmazonSearch.txt");

            driver.Navigate().GoToUrl("https://www.amazon.com/");
            driver.Manage().Window.Maximize();
            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(mySearch);
            searchBox.Click();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}