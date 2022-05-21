
using OpenQA.Selenium;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace Project_Havryliuk_Oleksandr_Kyiv
{

    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//button[@mode='primary']")]
        private IWebElement AgreeButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@href,'.lipsum.')]")]
        private IList<IWebElement> ListLanguageButtons { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Panes']/div[1]/p")]
        private IWebElement FirstParagraph { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='generate']")]
        private IWebElement GenerateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for !='start']")]
        private IList<IWebElement> ListRadioButtons { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='amount']")]
        private IWebElement InputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for ='start']")]
        private IWebElement Checkbox { get; set; }

        internal void ClickAgreeCookies() 
        {
            AgreeButton.Click(); 
        }
        
        public HomePage(IWebDriver driver): base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        internal IList<IWebElement> GetListLanguageButtons()
        {
            return ListLanguageButtons;
        }

        internal IList<IWebElement> GetListRadioButtons()
        {
            return ListRadioButtons;
        }

        internal IWebElement GetGenerateButton()
        {
            return GenerateButton;
        }

        internal IWebElement GetFirstParagraph()
        {
            return FirstParagraph;
        }

        public IWebElement GetInputField()
        {
            return InputField;
        }

        internal IWebElement GetCheckbox()
        {
            return Checkbox;
        }


        internal void ClickGenerateButton()
        {
            GenerateButton.Click();
        }

        internal void ClickCheckBox()
        {
            Checkbox.Click();
        }
    }  
}