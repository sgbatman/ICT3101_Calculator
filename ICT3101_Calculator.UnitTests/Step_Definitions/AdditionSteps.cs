﻿using NUnit.Framework;
using ICT3101_Calculator;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{

    [Binding]
    public class AdditionSteps
    {

        private Calculator _calculator;
        private double _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}