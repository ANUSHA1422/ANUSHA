
using OpenQA.Selenium;
using testing.utilities;

namespace testing.pages
{
    public class homepage
    {
        public void goToTmPage(IWebDriver driver)
        {
            IWebElement AdministrationButton = driver.FindElement(By.XPath(" / html / body / div[3] / div / div / ul / li[5] / a"));
            AdministrationButton.Click();

            waithelpers.WaitToBeClickable(driver, "XPath", "/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a", 3);

            IWebElement TimematerialOption = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            TimematerialOption.Click();
        }
    }
}
