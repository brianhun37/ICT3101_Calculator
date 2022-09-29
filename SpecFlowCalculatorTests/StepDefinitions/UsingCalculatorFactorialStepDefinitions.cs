using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        private Exception _actualException;
        
        public UsingCalculatorFactorialStepDefinitions(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            try
            {
                _result = _calculator.Factorial(p0);
            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBeOnScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the error '([^']*)' should be displayed")]
        public void ThenTheErrorShouldBeDisplayed(string p0)
        {
            Assert.AreEqual(p0, _actualException.Message);
        }
    }
}
