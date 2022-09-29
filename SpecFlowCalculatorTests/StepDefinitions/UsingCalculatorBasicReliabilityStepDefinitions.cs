using System;
using TechTalk.SpecFlow;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        private Exception _actualException;

        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"the initial failure intensity is (.*) and the average number of failures is (.*) and the total number of failure over infinite time is (.*) and press current failure intensity")]
        public void WhenTheInitialFailureIntensityIsAndTheAverageNumberOfFailuresIsAndTheTotalNumberOfFailureOverInfiniteTimeIsAndPressCurrentFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calculator.CalculateCurrentFailureIntensity(p0, p1, p2);
        }

        [Then(@"the current failure intensity should be (.*)")]
        public void ThenTheCurrentFailureIntensityShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"the initial failure intensity is (.*) and the average number of failures is (.*) and the total number of failure over infinite time is (.*) and the number of CPU hours is (.*) and press average number of failures")]
        public void WhenTheInitialFailureIntensityIsAndTheAverageNumberOfFailuresIsAndTheTotalNumberOfFailureOverInfiniteTimeIsAndTheNumberOfCPUHoursIsAndPressAverageNumberOfFailures(int p0, int p1, int p2, int p3)
        {
            _result = _calculator.CalculateAverageNoOfFailures(p0, p1, p2, p3);
        }

        [Then(@"the average number of failures expected should be (.*)")]
        public void ThenTheAverageNumberOfFailuresExpectedShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
