
using OpenQA.Selenium;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace Project_Havryliuk_Oleksandr_Kyiv
{

    public class HomePage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//*[contains(@href,'.lipsum.')]")]
        public IList<IWebElement> ListLanguageButtons;

        [FindsBy(How = How.XPath, Using = "//*[@id='Panes']/div[1]/p")]
        public IWebElement FirstParagraph;

        [FindsBy(How = How.XPath, Using = "//*[@id='generate']")]
        public IWebElement GenerateButton;

        [FindsBy(How = How.XPath, Using = "//label[@for !='start']")]
        public IList<IWebElement> ListRadioButtons;

        [FindsBy(How = How.XPath, Using = "//input[@name='amount']")]
        public IWebElement InputField;

        [FindsBy(How = How.XPath, Using = "//label[@for ='start']")]
        public IWebElement Checkbox;

        public HomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        internal void ClickLanguageButton(string language)
        {
            for(int i = 0; i < ListLanguageButtons.Count; i++)
            {
                if (ListLanguageButtons[i].GetAttribute("href").Contains(language)){ ListLanguageButtons[i].Click(); }
            }  
        }

        internal void CheckFirstParagraphContains(string word)
        {
            FirstParagraph.Text.Contains(word);
        }

        internal void ClickGenerateButton()
        {
            GenerateButton.Click();
        }

        internal void ClickItemsButton(string item)
        {
            for (int i = 0; i < ListRadioButtons.Count; i++)
            {
                if (ListRadioButtons[i].Text == item)
                {
                    ListRadioButtons[i].Click();
                }
            }
        }

        internal void MakeInput(int input)
        {
            int defaultAmount = 5;
            InputField.Clear();

            if (input <= 0)
            {
                input = defaultAmount;
            }

            InputField.SendKeys(input.ToString());
        }

        internal void ClickCheckBox()
        {
            Checkbox.Click();
        }
    }  
}