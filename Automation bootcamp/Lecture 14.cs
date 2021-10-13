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
    [Parallelizable(ParallelScope.All)]
    class Lecture_14
    {

        [Test]
        [Category("Lecture_14")]
        public void AddItemOneToCart()
        {
            IWebDriver driver;
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://tailspintoys.azurewebsites.net/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.CssSelector("a[title='Browse Model Airplanes']")).Click();
            driver.FindElement(By.XPath("//p[2]/a[@href='/home/show?sku=modfcf']")).Click();
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            driver.FindElement(By.CssSelector("input[title='Proceed to checkout']")).Click();

            driver.FindElement(By.Id("FirstName")).SendKeys("Nate");
            driver.FindElement(By.Id("LastName")).SendKeys("E");
            driver.FindElement(By.Id("Email")).SendKeys("Email@test.com");
            driver.FindElement(By.Id("Street1")).SendKeys("123 test lane");
            driver.FindElement(By.Id("City")).SendKeys("Test");
            driver.FindElement(By.Id("Zip")).SendKeys("12345");
            driver.FindElement(By.XPath("//select[@id='stateSelect']/option[@value='FL']")).Click();

            driver.FindElement(By.CssSelector("input[value='Review Order']")).Click();
            driver.FindElement(By.CssSelector("input[value='Place Order']")).Click();

            IWebElement ReceiptText = driver.FindElement(By.XPath("//*[@id='bdy']/h1/cufon[1]/cufontext"));

            Assert.IsNotEmpty(ReceiptText.ToString());
            driver.Quit();
        }

        [Test]
        [Category("Lecture_14")]
        public void AddItemTwoToCart()
        {

            IWebDriver driver;
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://tailspintoys.azurewebsites.net/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.CssSelector("a[title='Browse Model Airplanes']")).Click();
            driver.FindElement(By.XPath("//p[2]/a[@href='/home/show?sku=modfcf']")).Click();
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            driver.FindElement(By.CssSelector("input[title='Proceed to checkout']")).Click();

            driver.FindElement(By.Id("FirstName")).SendKeys("Nate");
            driver.FindElement(By.Id("LastName")).SendKeys("E");
            driver.FindElement(By.Id("Email")).SendKeys("Email@test.com");
            driver.FindElement(By.Id("Street1")).SendKeys("123 test lane");
            driver.FindElement(By.Id("City")).SendKeys("Test");
            driver.FindElement(By.Id("Zip")).SendKeys("12345");
            driver.FindElement(By.XPath("//select[@id='stateSelect']/option[@value='FL']")).Click();

            driver.FindElement(By.CssSelector("input[value='Review Order']")).Click();
            driver.FindElement(By.CssSelector("input[value='Place Order']")).Click();

            IWebElement ReceiptText = driver.FindElement(By.XPath("//*[@id='bdy']/h1/cufon[1]/cufontext"));

            Assert.IsNotEmpty(ReceiptText.ToString());
            driver.Quit();
        }

    }
}
