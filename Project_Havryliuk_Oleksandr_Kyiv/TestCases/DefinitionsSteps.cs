
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
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
        }


        [Given(@"User clicks switch language to '(.*)' button")]
        public void GivenUserClicksSwitchLanguageToButton(string language)
        {
            var homePage = new HomePage(driver);
            homePage.ClickLanguageButton(language);
        }

        [Then(@"User checks first paragraph contains '(.*)'")]
        public void ThenUserChecksFirstParagraphContains(string word)
        {
            var homePage = new HomePage(driver);
            homePage.CheckFirstParagraphContains(word);
        }

        [Given(@"User clicks on 'Generate' button")]
        public void GivenUserClicksOnButton()
        {
            var homePage = new HomePage(driver);
            homePage.ClickGenerateButton();
        }

        [Then(@"User checks first paragraph start with default sentence")]
        public void ThenUserChecksFirstParagraphStartWithDefaultSentence()
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckFirstParagraphStart();
        }

        [Given(@"User clicks on '(.*)' radiobutton")]
        public void GivenUserClicksOnRadiobutton(string item)
        {
            var homePage = new HomePage(driver);
            homePage.ClickItemsButton(item);
        }

        [When(@"User makes input is (.*)")]
        public void WhenUserMakesInputIs(int input)
        {
            var homePage = new HomePage(driver);
            homePage.MakeInput(input);
        }

        [Then(@"User checks generated info displays correctly amount of '(.*)'")]
        public void ThenUserChecksGeneratedInfoDisplaysCorrectlyAmount(string item)
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckCorrectlyAmount(item);
        }
        [Given(@"User clicks on checkbox")]
        public void GivenUserClicksOnCheckbox()
        {
            var homePage = new HomePage(driver);
            homePage.ClickCheckBox();
        }

        [Then(@"User checks first paragraph doesn't start with default sentence")]
        public void ThenUserChecksFirstParagraphDoesnTStartWithDefaultSentence()
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckFirstParagraphStart();
        }

        [Given(@"User checks amount of paragraphs contains word '(.*)'")]
        public void GivenUserChecksAmountOfParagraphsContainsWord(string word)
        {
            var generatePage = new GeneratePage(driver);
            generatePage.CheckAmountParagraphsContainWord(word);
        }


        [Given(@"User clicks on 'HomePage' button")]
        public void GivenUserClicksOnHomePageButton()
        {
            var generatePage = new GeneratePage(driver);
            generatePage.ClickHomePageButton();
        }

        [When(@"User repeat from one to third steps (.*) times with check word '(.*)'")]
        public void WhenUserRepeatSecondAndThirdStepsNumberOfGenerations_Times(int numberOfGenerations, string word)
        {
            for (int i = 0; i < numberOfGenerations; i++)
            {
                var homePage = new HomePage(driver);
                homePage.ClickGenerateButton();

                var generatePage = new GeneratePage(driver);
                generatePage.CheckAmountParagraphsContainWord(word);
                generatePage.ClickHomePageButton();
            }
        }

        [Then(@"User checks correct avarage of paragraps with (.*) generations")]
        public void ThenUserChecksCorrectAvarageOfParagrapsWhatIncludeWord(int numberOfGenerations)
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
