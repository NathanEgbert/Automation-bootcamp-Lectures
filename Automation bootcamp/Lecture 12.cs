using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace Automation_bootcamp
{
    public class Lecture12
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [Test]
        [Category("Lecture_12")]
        public void PopulateInputFields()
        {
            driver.Navigate().GoToUrl("https://www.c-sharpcorner.com/register");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.getElementById('ctl00_ContentMain_DropdownListCountry').value='United States'");
            js.ExecuteScript("document.getElementById('ctl00_ContentMain_DropdownListSecurityQuesion').value='1'");
            Thread.Sleep(500);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
