using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Q4.SeleniumAndAppiumAutomation
{
    public class GoogleSearch
    {
        [Test]
        public void GoogleSearchResult()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1200);

            driver.FindElement(By.LinkText("English")).Click();

            driver.FindElement(By.Id("APjFqb")).Click();



            driver.FindElement(By.Id("APjFqb")).SendKeys("Test Automation");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("APjFqb")).SendKeys(Keys.Enter);

            Assert.That(driver.FindElement(By.CssSelector(".Ap1Qsc .YmvwI")).Text, Is.EqualTo("All"));


            driver.Quit();
        }
    }
}