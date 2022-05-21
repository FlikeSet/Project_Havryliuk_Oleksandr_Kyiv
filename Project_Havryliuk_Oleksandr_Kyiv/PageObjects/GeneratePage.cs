using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Project_Havryliuk_Oleksandr_Kyiv.PageObjects
{
    public class GeneratePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='generated']")]
        private IWebElement GeneratedInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='Lorem Ipsum']")]
        private IWebElement HomePageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']//p")]
        private IList<IWebElement> AllParagraphs { get; set; }

        internal GeneratePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        internal IList<IWebElement> GetAllParagraphs()
        {
            return AllParagraphs;
        }

        internal IWebElement GetGeneratedInfo()
        {
            return GeneratedInfo;
        }

        internal IWebElement GetHomePageButton()
        {
            return HomePageButton;
        }

        internal void ClickHomePageButton()
        {
            HomePageButton.Click();
        }  
    }
}
