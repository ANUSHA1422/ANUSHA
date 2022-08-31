
using OpenQA.Selenium;

namespace testing.pages
{
    public class homepage
    {
        public void goTOTmPage(IWebDriver driver)
        {
            IWebElement AdministrationButton = driver.FindElement(By.XPath(" / html / body / div[3] / div / div / ul / li[5] / a"));
            AdministrationButton.Click();

            IWebElement TimematerialOption = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            TimematerialOption.Click();
        }
    }
}
