namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        IFileReader fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            fileReader = new FileReader();
        }
        
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(10, -20, ExpectedResult = -10)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(-10, 20, ExpectedResult = 10)]
        [TestCase(-10, -20, ExpectedResult = -30)]
        [TestCase(-10, 0, ExpectedResult = -10)]
        public double Add_WhenAddingTwoNumbers_ResultEqualToSum(int num1, int num2)
        {
            return _calculator.Add(num1, num2);
        }

        [TestCase(10, 20, ExpectedResult = -10)]
        [TestCase(10, -20, ExpectedResult = 30)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(-10, 20, ExpectedResult = -30)]
        [TestCase(-10, -20, ExpectedResult = 10)]
        [TestCase(-10, 0, ExpectedResult = -10)]
        public double Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract(int num1, int num2)
        {
            return _calculator.Subtract(num1, num2);
        }

        [TestCase(10, 20, ExpectedResult = 200)]
        [TestCase(10, -20, ExpectedResult = -200)]
        [TestCase(10, 0, ExpectedResult = 0)]
        [TestCase(-10, 20, ExpectedResult = -200)]
        [TestCase(-10, -20, ExpectedResult = 200)]
        [TestCase(-10, 0, ExpectedResult = 0)]
        public double Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiplication(int num1, int num2)
        {
            return _calculator.Multiply(num1, num2);
        }

        [TestCase(10, 20, ExpectedResult = 0.5)]
        [TestCase(10, -20, ExpectedResult = -0.5)]
        [TestCase(-10, 20, ExpectedResult = -0.5)]
        [TestCase(-10, -20, ExpectedResult = 0.5)]
        public double Divide_WhenDividingTwoNumbers_ResultEqualToDivision(int num1, int num2)
        {
            return _calculator.Divide(num1, num2);
        }

        //[TestCase(10, 0)]
        //[TestCase(-10, 0)]
        //[TestCase(0, 0)]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int num1, int num2)
        //{
        //    Assert.Throws<ArgumentException>(() => _calculator.Divide(num1, num2));
        //}

        //[Test]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException()
        //{
        //    Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        //}

        [TestCase(0, ExpectedResult = 1)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(10, ExpectedResult = 3628800)]
        public double Factorial_WithWholeNumber_ResultEqualToFactorialNumber(int num)
        {
            return _calculator.Factorial(num);
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void Factorial_WithNegativeAsInput_ResultThrowArgumentException(int num)
        {
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(num));
        }

        // Triangle
        [TestCase(10, 4, ExpectedResult = 20)]
        public double TriangleArea_WithPositiveNumbers_ResultEqualToArea(double height, double width)
        {
            return _calculator.TriangleArea(height, width);
        }

        [TestCase(-10, 4)]
        [TestCase(10, -4)]
        [TestCase(-10, -4)]
        public void TriangleArea_WithNegativeNumbers_ResultThrowArgumentException(double h, double l)
        {
            Assert.Throws<ArgumentException>(() => _calculator.TriangleArea(h, l));
        }

        [TestCase(0, 4)]
        [TestCase(10, 0)]
        [TestCase(0, 0)]
        public void TriangleArea_WithZeros_ResultThrowArgumentException(double h, double l)
        {
            Assert.Throws<ArgumentException>(() => _calculator.TriangleArea(h, l));
        }

        // Circle
        [TestCase(7, ExpectedResult = 154)]
        public double CircleArea_WithPositiveNumbers_ResultEqualToArea(double radius)
        {
            return _calculator.CircleArea(radius);
        }

        [TestCase(-10)]
        public void CircleArea_WithNegativeNumbers_ResultThrowArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => _calculator.CircleArea(radius));
        }

        [TestCase(0)]
        public void CircleArea_WithZeros_ResultThrowArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => _calculator.CircleArea(radius));
        }

        [TestCase(5, 5, ExpectedResult = 120)]
        [TestCase(5, 4, ExpectedResult = 120)]
        [TestCase(5, 3, ExpectedResult = 60)]
        public double UnknownFunctionA_WhenGivenTest0To2_Result(double num1, double num2)
        {
            return _calculator.unknownFunctionA(num1, num2);
        }

        [TestCase(-4, 5)]
        [TestCase(4, 5)]
        public void UnknownFunctionA_WhenGivenTest3To4_ResultThrowArgumnetException(double num1, double num2)
        {
            Assert.Throws<ArgumentException>(() => _calculator.unknownFunctionA(num1, num2));
        }

        [TestCase(5, 5, ExpectedResult = 1)]
        [TestCase(5, 4, ExpectedResult = 5)]
        [TestCase(5, 3, ExpectedResult = 10)]
        public double UnknownFunctionB_WhenGivenTest0To2_Result(double num1, double num2)
        {
            return _calculator.unknownFunctionB(num1, num2);
        }

        [TestCase(-4, 5)]
        [TestCase(4, 5)]
        public void UnknownFunctionB_WhenGivenTest3To4_ResultThrowArgumnetException(double num1, double num2)
        {
            Assert.Throws<ArgumentException>(() => _calculator.unknownFunctionB(num1, num2));
        }
        [Test]
        [TestCase(-3)]
        public void GenMagicNum_WhenGivenNegativeValue_ResultsEquals0(double input)
        {

            Assert.That(() => _calculator.GenMagicNum(input, fileReader), Is.EqualTo(0));
        }

        [Test]
        [TestCase(0)]
        public void GenMagicNum_WhenGivenIndex0_ResultsEquals10(double input)
        {
            Assert.That(() => _calculator.GenMagicNum(input, fileReader), Is.EqualTo(10));
        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WhenGivenIndex1_ResultsEquals0(double input)
        {
            Assert.That(() => _calculator.GenMagicNum(input, fileReader), Is.EqualTo(0));
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WhenGivenIndex2_ResultsEqualNeg2(double input)
        {
            Assert.That(() => _calculator.GenMagicNum(input, fileReader), Is.EqualTo(2));
        }
    }
}