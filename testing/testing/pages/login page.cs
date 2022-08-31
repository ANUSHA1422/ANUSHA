
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace testing.pages
{
    public class login_page
    {
        public void loginsteps(IWebDriver driver)
        {
           
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(2000);

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }

    }
}
