using System;
using TechTalk.SpecFlow;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        private Exception _actualException;

        public UsingCalculatorAvailabilityStepDefinitions(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            try
            {
                _result = _calculator.CalculateMTBF(p0, p1);
            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            try
            {
                _result = _calculator.CalculateAvailability(p0, p1);

            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
