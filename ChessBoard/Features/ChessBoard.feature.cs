// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ChessBoard.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Taking a piece.")]
    public partial class TakingAPiece_Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ChessBoard.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Taking a piece.", "In order to play chess\r\nAs a Player\r\nI want to be able to take the oppositions pi" +
                    "ece.", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pawn at top.")]
        public virtual void PawnAtTop_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn at top.", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("I have A White Pawn at A8");
#line 8
testRunner.When("I try and move to A9");
#line 9
testRunner.Then("I should be warned of an illegal move message.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Knight heads off board")]
        public virtual void KnightHeadsOffBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Knight heads off board", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
testRunner.Given("I have a Black knight at G8");
#line 13
testRunner.When("I try and move to I7");
#line 14
testRunner.Then("I should be warned of an illegal move message.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pawn moves legally.")]
        public virtual void PawnMovesLegally_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn moves legally.", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
testRunner.Given("I have A White Pawn at a7");
#line 18
testRunner.When("I try and move to a8");
#line 19
testRunner.Then("I should be shown \"Pawn to A8\"");
#line 20
testRunner.And("Pawn should be at A8.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Knight moves legally")]
        public virtual void KnightMovesLegally()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Knight moves legally", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
testRunner.Given("I have a Black knight at G8");
#line 24
testRunner.When("I try and move to H6");
#line 25
testRunner.Then("I should be shown \"Knight to H6\"");
#line 26
testRunner.And("Knight should be at H6.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pawn Starts on home row.")]
        public virtual void PawnStartsOnHomeRow_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn Starts on home row.", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
testRunner.Given("the game has just started");
#line 35
testRunner.And("the Pawn is on B2");
#line 36
testRunner.And("the Knight is at G8");
#line 37
testRunner.When("I move to B3");
#line 38
testRunner.Then("I should be shown “Pawn to B3”");
#line 39
testRunner.And("Pawn should be at B3.");
#line 41
testRunner.Given("the game has just started");
#line 42
testRunner.And("the Pawn is on E2");
#line 43
testRunner.And("the Knight is at G8");
#line 44
testRunner.When("I move to E4");
#line 45
testRunner.Then("I should be shown “Pawn to E4”");
#line 46
testRunner.And("Pawn should be at E4.");
#line 48
testRunner.Given("the game has not just started");
#line 49
testRunner.And("the Pawn is on D2");
#line 50
testRunner.And("the Knight is at G8");
#line 51
testRunner.When("I move to D4");
#line 52
testRunner.Then("I should be shown \"Pawn cannot move 2 spaces unless it in the first round and is " +
                    "on the home row.\"");
#line 53
testRunner.And("Pawn should be at D2.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pawn tries taking move when nothing to capture")]
        public virtual void PawnTriesTakingMoveWhenNothingToCapture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn tries taking move when nothing to capture", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("the Pawn is on D7");
#line 57
testRunner.And("the Knight is at G8");
#line 58
testRunner.When("I move to C8");
#line 59
testRunner.Then("I should be shown “Pawn cannot diagonally unless it is capturing a piece.”");
#line 60
testRunner.And("Pawn should be at D7.");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Moving the knight legally")]
        public virtual void MovingTheKnightLegally()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Moving the knight legally", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
testRunner.Given("It is the knight’s turn");
#line 69
testRunner.And("the knight is at D4");
#line 70
testRunner.When("I move to F5");
#line 71
testRunner.Then("I should be shown “Knight to F5”");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pawn Takes the Knight")]
        public virtual void PawnTakesTheKnight()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn Takes the Knight", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
testRunner.Given("It is the pawn’s turn.");
#line 80
testRunner.And("the pawn is at D3");
#line 81
testRunner.And("the knight is at C4");
#line 82
testRunner.When("the pawn moves to C4");
#line 83
testRunner.Then("the knight should be taken");
#line 84
testRunner.And("the pawn should be at C4");
#line 85
testRunner.And("I should be shown. “Pawn takes Knight. Pawn wins”");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pawn collides with Knight.")]
        public virtual void PawnCollidesWithKnight_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn collides with Knight.", ((string[])(null)));
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
testRunner.Given("It is the pawn’s turn.");
#line 89
testRunner.And("the pawn is at C3");
#line 90
testRunner.And("the knight is at C4");
#line 91
testRunner.When("the pawn moves to C4");
#line 92
testRunner.Then("the knight should be At C4");
#line 93
testRunner.And("the pawn should be at C3");
#line 94
testRunner.And("I should be shown. \"Pawn collides with Knight. Draw.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Knight takes Pawn.")]
        public virtual void KnightTakesPawn_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Knight takes Pawn.", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
testRunner.Given("it is the Knights turn");
#line 98
testRunner.And("the Pawn is at F7");
#line 99
testRunner.And("the Knight is at D6");
#line 100
testRunner.When("I move to F7");
#line 101
testRunner.Then("the pawn should be taken");
#line 102
testRunner.And("I should be shown \"Knight takes Pawn. Knight Wins\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion