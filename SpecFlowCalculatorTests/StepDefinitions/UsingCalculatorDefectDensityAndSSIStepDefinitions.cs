using System;
using TechTalk.SpecFlow;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDefectDensityAndSSIStepDefinitions
    {

        private Calculator _calculator;
        private double _result;
        private Exception _actualException;

        public UsingCalculatorDefectDensityAndSSIStepDefinitions(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"the total number of defects is (.*) and the number of KLOC is (.*) and press defect density")]
        public void WhenTheTotalNumberOfDefectsIsAndTheNumberOfKLOCIsAndPressDefectDensity(int p0, int p1)
        {
            _result = _calculator.CalculateDefectDensity(p0, p1);
        }

        [Then(@"the defect density is (.*)")]
        public void ThenTheDefectDensityIs(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"the number of KSSI is (.*) and the number of KCSI is (.*) and the number of deleted/changed code is (.*) and press SSI")]
        public void WhenTheNumberOfKSSIIsAndTheNumberOfKCSIIsAndTheNumberOfDeletedChangedCodeIsAndPressSSI(int p0, int p1, int p2)
        {
            _result = _calculator.CalculateNewTotalSSI(p0, p1, p2);
        }

        [Then(@"the new total SSI is (.*)")]
        public void ThenTheNewTotalSSIIs(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
