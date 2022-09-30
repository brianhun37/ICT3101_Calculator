using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("../../../../ICT3101_Calculator/MagicNumbers.txt")).Returns(new string[5] { "-5", "0", "1", "2", "3" });
            _calculator = new Calculator();
        }
        [Test]
        [TestCase(-3)]
        public void GenMagicNum_WhenGivenNegativeValue_ResultsEquals0(double input)
        {

            Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(0));
        }

        [Test]
        [TestCase(0)]
        public void GenMagicNum_WhenGivenIndex0_ResultsEquals10(double input)
        {
            Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(10));
        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WhenGivenIndex1_ResultsEquals0(double input)
        {
            Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(0));
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WhenGivenIndex2_ResultsEqualNeg2(double input)
        {
            Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(2));
        }
    }
}
