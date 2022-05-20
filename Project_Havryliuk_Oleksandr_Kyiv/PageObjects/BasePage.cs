using OpenQA.Selenium;


namespace Project_Havryliuk_Oleksandr_Kyiv.PageObjects
{
    public class BasePage
    {
        public IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
