using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestCalcIntegration
{
    [TestClass]
    public class CalculatorWebTests
    {
        IWebDriver _driver;

        [TestInitialize]

        public void Startup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [DataTestMethod]
        public void TestWebsiteAdds()
        {

            _driver.Navigate().GoToUrl("https://localhost:5000/");

            var left = _driver.FindElement(By.CssSelector("input[name=left]"));
            var right = _driver.FindElement(By.CssSelector("input[name=right]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            left.SendKeys("1");
            right.SendKeys("1");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(2.ToString(), output.Text);
        }

        [TestCleanup]
        public void ShutDown()
        {
            _driver.Quit();
        }

    }
}
