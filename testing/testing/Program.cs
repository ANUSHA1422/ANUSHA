using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(2000);

IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
if (helloHari.Text == "Hello hari!")
{

    Console.WriteLine("logged in successfully,test passed.");
}

else
{
    Console.WriteLine("login failed,test failed");
}

IWebElement AdministrationButton = driver.FindElement(By.XPath(" / html / body / div[3] / div / div / ul / li[5] / a"));
AdministrationButton.Click();

IWebElement TimematerialOption = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
TimematerialOption.Click();

IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
CreateNewButton.Click();

IWebElement TypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[2]/span"));
TypeCodeDropDown.Click();

IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("abc");

IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
DescriptionTextBox.SendKeys("abc");

IWebElement PriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
PriceTag.Click();

IWebElement PriceTextBox = driver.FindElement(By.Id("Price"));
PriceTextBox.SendKeys("22");

IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(4000);

IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
GoToLastPageButton.Click();

IWebElement NewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (NewCode.Text == "abc")
{
    Console.WriteLine("new record successfully created.");
 }

else

{
    Console.WriteLine("new record unsuccessfull.");

}
