using System.Threading;
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


Thread.Sleep(2000);



//ebElement GoToEditButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[10]/td[5]a[1]"));
//ToEditButton.Click();//

//ebElement EditTcDd = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[1]"));
//itTcDd.Click();

//ebElement EditCodeTb = driver.FindElement(By.Id("Code"));
//itCodeTb.SendKeys("mrng");

//ditDescriptionTb.SendKeys("mrng");

//ebElement NewPriceTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span"));
//wPriceTag.Click();

//ditPrice.SendKeys("14");

//ebElement GoToSaveButton = driver.FindElement(By.Id("SaveButton"));
//ToSaveButton.Click();

//oToBl.Click();

//IWebElement GoToPage947 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[3]/span"));
//GoToPage947.Click();//

//ebElement Codeabc = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[10]/td[1]"));
// (Codeabc.Text =="mrng")
//  //onsole.WriteLine("Edit successfull.");//

//

//se
// //Console.WriteLine("Edit unsuccessfull.");
//


IWebElement GoToEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
GoToEditButton.Click();

IWebElement editTypeCodeTexbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
editTypeCodeTexbox.Click();

IWebElement EditCodeTB = driver.FindElement(By.Id("Code"));
EditCodeTB.SendKeys("mrng");

IWebElement EditDescriptionTB = driver.FindElement(By.Id("Description"));
EditDescriptionTB.SendKeys("mrng");

IWebElement EditPriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
EditPriceTag.Click();

IWebElement EditPrice = driver.FindElement(By.Id("Price"));
EditPrice.SendKeys("14");

IWebElement GoToSaveButton = driver.FindElement(By.Id("SaveButton"));
GoToSaveButton.Click();
Thread.Sleep(1000);

IWebElement GoToLPButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
GoToLPButton.Click();

Thread.Sleep(1000);

IWebElement EditNewcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (EditNewcode.Text == "abcmrng")
{
    Console.WriteLine("edit successfull");
}

else
{
    Console.WriteLine("edit unsuccessfull");
}

//Thread.Sleep(1000);

//IWebElement goToEditNewCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
//goToEditNewCode.Click();
//IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
//goToDeleteButton.Click();















