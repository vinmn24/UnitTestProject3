using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject3
{
    [Binding]
    public class TestSteps
    {
        int no1, no2, total;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number1)
        {
            no1 = number1;
        }

        [Given(@"we have also entered (.*) into the calculator")]
        public void GivenWeHaveAlsoEnteredIntoTheCalculator(int number2)
        {
            no2 = number2;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            total = no1 + no2;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int ExpectedTotal)
        {
            Assert.AreEqual(ExpectedTotal,total);
        }
    }
}
