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
        public IWebElement GeneratedInfo;

        [FindsBy(How = How.XPath, Using = "//a[@title='Lorem Ipsum']")]
        public IWebElement HomePageButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']//p")]
        public IList<IWebElement> AllParagraphs;
        
        public static double counter = 0;
        public GeneratePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        internal void CheckFirstParagraphStart()
        {
            string firstParagraphText = AllParagraphs[0].Text;
            string testSentense = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            Assert.IsTrue(firstParagraphText.Substring(0, 25) != testSentense.Substring(0, 25));
        }

        internal void CheckCorrectlyAmount(string item)
        {
            int counter = 0, index = 0;
            switch (item)
            {

                case "words":
                    
                    string firstParagraphText = AllParagraphs[0].Text;

                    while (index < firstParagraphText.Length && char.IsWhiteSpace(firstParagraphText[index]))
                        index++;

                    while (index < firstParagraphText.Length)
                    {
                        while (index < firstParagraphText.Length && !char.IsWhiteSpace(firstParagraphText[index]))
                            index++;

                        counter++;

                        while (index < firstParagraphText.Length && char.IsWhiteSpace(firstParagraphText[index]))
                            index++;
                    }

                    Assert.IsTrue(GeneratedInfo.Text.Contains(counter.ToString()));
                    break;
                case "bytes":
                    for (int i = 0; i < AllParagraphs[0].Text.Length; i++)
                    {

                        counter++;

                    }

                    Assert.IsTrue(GeneratedInfo.Text.Contains(counter.ToString()));
                    break;
                case "paragraphs":
                    counter = AllParagraphs.Count;
                    Assert.IsTrue(GeneratedInfo.Text.Contains(counter.ToString()));
                    break;
                case "lists":
                    counter = AllParagraphs.Count / 2;
                    Assert.IsTrue(GeneratedInfo.Text.Contains(" " + counter.ToString() + " "));
                    break;
            }
            
        }

        internal void ClickHomePageButton()
        {
            HomePageButton.Click();
        }


        internal void CheckCorrectlyAvarage(int numberOfGenerations)
        {
            double avarageCountParagraps = counter / numberOfGenerations;
            Assert.IsTrue(2 < avarageCountParagraps && avarageCountParagraps < 3);
        }

        internal void CheckAmountParagraphsContainWord(string word)
        {
            for (int i = 0; i < AllParagraphs.Count; i++)
            {
                string paragraphText = AllParagraphs[i].Text;
                if (Regex.IsMatch(paragraphText, Regex.Escape(word), RegexOptions.IgnoreCase)) { counter++; }
            }
        }
    }
}
