﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Project_Havryliuk_Oleksandr_Kyiv
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class LoremIpsumFeatureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LoremIpsumFeature.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "LoremIpsumFeature", "\tTest main functionality of www.lipsum.com", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "LoremIpsumFeature")))
            {
                global::Project_Havryliuk_Oleksandr_Kyiv.LoremIpsumFeatureFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CheckHomepageFirstParagraphRightWordContain(string language, string word, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("word", word);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check homepage first paragraph right word contain", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given(string.Format("User clicks switch language to \'{0}\' button", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then(string.Format("User checks first paragraph contains \'{0}\'", word), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check homepage first paragraph right word contain: uk")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "uk")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:language", "uk")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:word", "риба")]
        public void CheckHomepageFirstParagraphRightWordContain_Uk()
        {
#line 4
this.CheckHomepageFirstParagraphRightWordContain("uk", "риба", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check homepage first paragraph right word contain: en")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "en")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:language", "en")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:word", "dummy")]
        public void CheckHomepageFirstParagraphRightWordContain_En()
        {
#line 4
this.CheckHomepageFirstParagraphRightWordContain("en", "dummy", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check homepage first paragraph right word contain: pl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "pl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:language", "pl")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:word", "latach")]
        public void CheckHomepageFirstParagraphRightWordContain_Pl()
        {
#line 4
this.CheckHomepageFirstParagraphRightWordContain("pl", "latach", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check default start sentence of generated text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        public void CheckDefaultStartSentenceOfGeneratedText()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check default start sentence of generated text", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
 testRunner.Given("User clicks on \'Generate\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
 testRunner.Then("User checks first paragraph start with default sentence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void CheckCorrectGeneratedAmountOfItems(string input, string item, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("input", input);
            argumentsOfScenario.Add("item", item);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check correct generated amount of items", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 18
 testRunner.Given(string.Format("User clicks on \'{0}\' radiobutton", item), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 19
 testRunner.When(string.Format("User makes input is {0}", input), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Given("User clicks on \'Generate\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.Then(string.Format("User checks generated info displays correctly amount of \'{0}\'", item), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "words")]
        public void CheckCorrectGeneratedAmountOfItems_Variant0()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("10", "words", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "words")]
        public void CheckCorrectGeneratedAmountOfItems_Variant1()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("-1", "words", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "words")]
        public void CheckCorrectGeneratedAmountOfItems_Variant2()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("0", "words", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "words")]
        public void CheckCorrectGeneratedAmountOfItems_Variant3()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("5", "words", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "words")]
        public void CheckCorrectGeneratedAmountOfItems_Variant4()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("20", "words", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "bytes")]
        public void CheckCorrectGeneratedAmountOfItems_Variant5()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("10", "bytes", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "bytes")]
        public void CheckCorrectGeneratedAmountOfItems_Variant6()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("-1", "bytes", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "bytes")]
        public void CheckCorrectGeneratedAmountOfItems_Variant7()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("0", "bytes", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "bytes")]
        public void CheckCorrectGeneratedAmountOfItems_Variant8()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("5", "bytes", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "bytes")]
        public void CheckCorrectGeneratedAmountOfItems_Variant9()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("20", "bytes", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "lists")]
        public void CheckCorrectGeneratedAmountOfItems_Variant10()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("10", "lists", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "lists")]
        public void CheckCorrectGeneratedAmountOfItems_Variant11()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("-1", "lists", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 12")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 12")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "lists")]
        public void CheckCorrectGeneratedAmountOfItems_Variant12()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("0", "lists", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 13")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 13")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "lists")]
        public void CheckCorrectGeneratedAmountOfItems_Variant13()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("5", "lists", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 14")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 14")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "lists")]
        public void CheckCorrectGeneratedAmountOfItems_Variant14()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("20", "lists", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 15")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 15")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "paragraphs")]
        public void CheckCorrectGeneratedAmountOfItems_Variant15()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("10", "paragraphs", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 16")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 16")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "paragraphs")]
        public void CheckCorrectGeneratedAmountOfItems_Variant16()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("-1", "paragraphs", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 17")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 17")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "paragraphs")]
        public void CheckCorrectGeneratedAmountOfItems_Variant17()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("0", "paragraphs", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 18")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 18")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "paragraphs")]
        public void CheckCorrectGeneratedAmountOfItems_Variant18()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("5", "paragraphs", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct generated amount of items: Variant 19")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 19")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:input", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:item", "paragraphs")]
        public void CheckCorrectGeneratedAmountOfItems_Variant19()
        {
#line 17
this.CheckCorrectGeneratedAmountOfItems("20", "paragraphs", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct checkbox work")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        public void CheckCorrectCheckboxWork()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check correct checkbox work", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
 testRunner.Given("User clicks on checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
 testRunner.And("User clicks on \'Generate\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.Then("User checks first paragraph doesn\'t start with default sentence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void CheckCorrectAvarageOfParagraphsWhatIncludeCertainWord(string numberOfGenerations, string word, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("numberOfGenerations", numberOfGenerations);
            argumentsOfScenario.Add("word", word);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check correct avarage of paragraphs, what include certain word", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 52
 testRunner.Given("User clicks on \'Generate\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
 testRunner.And(string.Format("User checks amount of paragraphs contains word \'{0}\'", word), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("User clicks on \'HomePage\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.When(string.Format("User repeat from one to third steps {0} times with check word \'{1}\'", numberOfGenerations, word), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then(string.Format("User checks correct avarage of paragraps with {0} generations", numberOfGenerations), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check correct avarage of paragraphs, what include certain word: 10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LoremIpsumFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:numberOfGenerations", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:word", "lorem")]
        public void CheckCorrectAvarageOfParagraphsWhatIncludeCertainWord_10()
        {
#line 51
this.CheckCorrectAvarageOfParagraphsWhatIncludeCertainWord("10", "lorem", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
