using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBT_AutomationTest.src.test
{
    [TestClass]
    public class MansiGoogleTest
    {
        [TestMethod]
        public void Test()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("AccessHQ Brisbane"+Keys.Enter);
            string actualAddress = driver.FindElements(By.XPath(".//a[.='Address']//..//..//span"))[1].Text;
            Assert.AreEqual("144 Montague Rd, South Brisbane QLD 4101", actualAddress);
            driver.Close();
            driver.Quit();
        }
    }
}
