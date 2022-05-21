using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;

namespace Project_Havryliuk_Oleksandr_Kyiv.PageObjects
{
    public class BusinessLogicLayer
    {
        internal static readonly IWebDriver driver = new ChromeDriver();

        internal HomePage homePage = new HomePage(driver);

        internal GeneratePage generatePage = new GeneratePage(driver);

        #region HomePageFuncs

        internal readonly int defaultInputAmount = 5;

        internal bool CheckFirstParagraph(string word)
        {
            var GetFirstParagraphText = homePage.GetFirstParagraph().Text;
            return GetFirstParagraphText.Contains(word);
        }

        internal void MakeInput(int input)
        {
            var GetInputField = homePage.GetInputField();
            GetInputField.Clear();

            if (input <= 0)
            {
                input = defaultInputAmount;
            }

            GetInputField.SendKeys(input.ToString());
        }

        internal void ClickLanguageButton(string language)
        {
            var LangButtons = homePage.GetListLanguageButtons();
            for (int i = 0; i < LangButtons.Count; i++)
            {
                if (LangButtons[i].GetAttribute("href").Contains(language)) { LangButtons[i].Click(); }
            }
        }

        internal void ClickItemsButton(string item)
        {
            var RadioButtons = homePage.GetListRadioButtons();
            for (int i = 0; i < RadioButtons.Count; i++)
            {
                if (RadioButtons[i].Text == item)
                {
                    RadioButtons[i].Click();
                }
            }
        }

        #endregion HomePageFuncs

        #region GeneratePageFuncs

        static int WordsCounter = 0;

        internal bool CheckFirstParagraphCorrectStart()
        {
            var AllParagrapsGen = generatePage.GetAllParagraphs();
            string FirstParagraphText = AllParagrapsGen[0].Text;
            string TestSentense = "Lorem ipsum dolor sit amet";
            return FirstParagraphText.Substring(0, 26) == TestSentense;
        }

        internal bool CheckCorrectlyAmount(string item)
        {
            int counter = 0, index = 0;

            var AllParagrapsGen = generatePage.GetAllParagraphs();
            string firstParagraphText = AllParagrapsGen[0].Text;
            var GeneratedInfoText = generatePage.GetGeneratedInfo().Text;

            switch(item)
            {
                case "words":
                    while (index < firstParagraphText.Length 
                        && char.IsWhiteSpace(firstParagraphText[index])) { index++; }
                        
                    while (index < firstParagraphText.Length)
                    {
                        while (index < firstParagraphText.Length 
                            && !char.IsWhiteSpace(firstParagraphText[index])) { index++; }

                        counter++;

                        while (index < firstParagraphText.Length 
                            && char.IsWhiteSpace(firstParagraphText[index])) { index++; }
                    }

                    return GeneratedInfoText.Contains(counter.ToString());

                case "bytes":
                    for (int i = 0; i < AllParagrapsGen[0].Text.Length; i++)
                    {

                        counter++;

                    }

                    return GeneratedInfoText.Contains(counter.ToString());

                case "paragraphs":
                    counter = AllParagrapsGen.Count;
                    return GeneratedInfoText.Contains(counter.ToString());

                case "lists":
                    counter = AllParagrapsGen.Count / 2;
                    return GeneratedInfoText.Contains(" " + counter.ToString() + " ");
                default:
                    return false;
            }

        }

        internal bool CheckCorrectlyAvarage(int numberOfGenerations)
        {
            var avarageCountParagraps = WordsCounter / numberOfGenerations;
            return 2 < avarageCountParagraps && avarageCountParagraps < 3;
        }

        internal void AmountParagraphsContainsWord(string word)
        {
            var AllParagrapsGen = generatePage.GetAllParagraphs();
            for (int i = 0; i < AllParagrapsGen.Count; i++)
            {
                string paragraphText = AllParagrapsGen[i].Text;
                if (Regex.IsMatch(paragraphText, Regex.Escape(word), RegexOptions.IgnoreCase)) { WordsCounter++; }
            }
        }

        #endregion GeneratePageFuncs

        internal void RepeatScenarioStepsAvarage(int numberOfGenerations, string word)
        {
            for (int i = 0; i < numberOfGenerations; i++)
            {
                homePage.ClickGenerateButton();
                AmountParagraphsContainsWord(word);
                generatePage.ClickHomePageButton();
            }
        }

    }
}
