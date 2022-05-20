
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace Project_Havryliuk_Oleksandr_Kyiv.TestCases
{
    [Binding]
    public class DefinitionsSteps
    {

        IWebDriver driver = new ChromeDriver();

        [BeforeScenario]
        public void OpenHomePage()
        {
            driver.Url = "https://www.lipsum.com/";
            //var homePage = new HomePage(driver);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //homePage.ClickAgreeCookies();
        }


        [Given(@"User clicks switch language to '(.*)' button")]
        public void ClickSwitchLanguageButton(string language)
        {
            var homePage = new HomePage(driver);
            homePage.ClickLanguageButton(language);
        }

        [Then(@"User checks first paragraph contains '(.*)'")]
        public void CheckFirstParagraphContains(string word)
        {
            var homePage = new HomePage(driver);
            homePage.CheckFirstParagraph(word);
        }

        [Given(@"User clicks on 'Generate' button")]
        public void ClickGenerateButton()
        {
            var homePage = new HomePage(driver);
            homePage.ClickGenerateButton();
        }

        [Then(@"User checks first paragraph start with default sentence")]
        public void CheckGeneratedFirstParagraphDefaultStart()
        {
            var generatePage = new GeneratePage(driver);
            Assert.IsTrue(generatePage.CheckFirstParagraphCorrectStart());
        }

        [Given(@"User clicks on '(.*)' radiobutton")]
        public void ClickRadioButton(string item)
        {
            var homePage = new HomePage(driver);
            homePage.ClickItemsButton(item);
        }

        [When(@"User makes input is (.*)")]
        public void MakeInput(int input)
        {
            var homePage = new HomePage(driver);
           homePage.MakeInput(input);
        }

        [Then(@"User checks generated info displays correctly amount of '(.*)'")]
        public void CheckCorrectGeneratedAmountValue(string item)
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckCorrectlyAmount(item);
        }
        [Given(@"User clicks on checkbox")]
        public void ClickCheckbox()
        {
            var homePage = new HomePage(driver);
            homePage.ClickCheckBox();
        }

        [Then(@"User checks first paragraph doesn't start with default sentence")]
        public void CheckGeneratedFirstParagraphCorrectStart()
        {
            var generatePage = new GeneratePage(driver);
            Assert.IsFalse(generatePage.CheckFirstParagraphCorrectStart());
        }

        [Given(@"User checks amount of paragraphs contains word '(.*)'")]
        public void CheckAmountParagraphsContainsWord(string word)
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckAmountParagraphsContainsWord(word);
        }


        [Given(@"User clicks on 'HomePage' button")]
        public void ClickHomePageButton()
        {
            var generatePage = new GeneratePage(driver);
            generatePage.ClickHomePageButton();
        }

        [When(@"User repeat from one to third steps (.*) times with check word '(.*)'")]
        public void RepeatScenarioStepsAvarageParagraphs(int numberOfGenerations, string word)
        {
            for (int i = 0; i < numberOfGenerations; i++)
            {
                var homePage = new HomePage(driver);
                homePage.ClickGenerateButton();

                var generatePage = new GeneratePage(driver);
                generatePage.CheckAmountParagraphsContainsWord(word);
                generatePage.ClickHomePageButton();
            }
        }

        [Then(@"User checks correct avarage of paragraps with (.*) generations")]
        public void CheckCorrectAvarageCalculation(int numberOfGenerations)
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckCorrectlyAvarage(numberOfGenerations);
        }

        [AfterScenario]
        public void CloseAllTabs()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
