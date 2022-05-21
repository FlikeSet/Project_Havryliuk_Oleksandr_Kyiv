
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace Project_Havryliuk_Oleksandr_Kyiv.TestCases
{
    [Binding]
    public class DefinitionsSteps : BusinessLogicLayer
    {
        [Before]
        public void OpenHomePage()
        {
            driver.Url = "https://www.lipsum.com/";
            try
            {
                var homePage = new HomePage(driver);
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                //homePage.ClickAgreeCookies();
            }
            catch (NoSuchElementException) { }

        }

        [Given(@"User clicks switch language to '(.*)' button")]
        public void ClickSwitchLanguageButton(string language)
        {
            ClickLanguageButton(language);
        }

        [Then(@"User checks first paragraph contains '(.*)'")]
        public void CheckFirstParagraphContains(string word)
        {
            Assert.IsTrue(CheckFirstParagraph(word));
        }

        [Given(@"User clicks on 'Generate' button")]
        public void ClickGenerateButton()
        {
            homePage.ClickGenerateButton();
        }

        [Then(@"User checks first paragraph start with default sentence")]
        public void CheckGeneratedFirstParagraphDefaultStart()
        {
            Assert.IsTrue(CheckFirstParagraphCorrectStart());
        }

        [Given(@"User clicks on '(.*)' radiobutton")]
        public void ClickRadioButton(string item)
        {
            ClickItemsButton(item);
        }

        [When(@"User makes input is (.*)")]
        public void TryMakeInput(int input)
        {
            MakeInput(input);
        }

        [Then(@"User checks generated info displays correctly amount of '(.*)'")]
        public void CheckCorrectGeneratedAmountValue(string item)
        {
            CheckCorrectlyAmount(item);
        }
        [Given(@"User clicks on checkbox")]
        public void ClickCheckbox()
        {
            homePage.ClickCheckBox();
        }

        [Then(@"User checks first paragraph doesn't start with default sentence")]
        public void CheckGeneratedFirstParagraphCorrectStart()
        {
            Assert.IsFalse(CheckFirstParagraphCorrectStart());
        }

        [Given(@"User checks amount of paragraphs contains word '(.*)'")]
        public void CheckAmountParagraphsIncludeWord(string word)
        {
            AmountParagraphsContainsWord(word);
        }

        [Given(@"User clicks on 'HomePage' button")]
        public void ClickHomePageButton()
        {
            generatePage.ClickHomePageButton();
        }

        [When(@"User repeat from one to third steps (.*) times with check word '(.*)'")]
        public void RepeatScenarioStepsAvarageParagraphs(int numberOfGenerations, string word)
        {
            RepeatScenarioStepsAvarage(numberOfGenerations,word);
        }

        [Then(@"User checks correct avarage of paragraps with (.*) generations")]
        public void CheckCorrectAvarageCalculation(int numberOfGenerations)
        {
            CheckCorrectlyAvarage(numberOfGenerations);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            driver.Quit();
        }
    }
}
