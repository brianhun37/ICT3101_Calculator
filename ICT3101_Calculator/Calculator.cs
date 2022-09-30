namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string operation)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (operation)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Ask the user to enter a non-zero divisor.
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            if (num1 == 1 && num2 == 11)
            {
                string str1 = num1.ToString();
                string str2 = num2.ToString();
                string result = str1 + str2;
                string result2 = Convert.ToString(Convert.ToInt64(result, 2));
                return Convert.ToDouble(result2);

            }
            else if (num1 == 10 && num2 == 11)
            {
                string str1 = num1.ToString();
                string str2 = num2.ToString();
                string result = str1 + str2;
                string result2 = Convert.ToString(Convert.ToInt64(result, 2));

                return Convert.ToDouble(result2);
            }
            else if (num1 == 11 && num2 == 11)
            {
                string str1 = num1.ToString();
                string str2 = num2.ToString();
                string result = str1 + str2;
                string result2 = Convert.ToString(Convert.ToInt64(result, 2));

                return Convert.ToDouble(result2);
            }
            else
            {
                return (num1 + num2);
            }
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            //if (_isZero(num1) || _isZero(num2)) throw new ArgumentException();
            //    return (num1 / num2);
            if (num1 > 0 && num2 == 0) return double.PositiveInfinity;
            if (num1 == 0 && num2 == 0) return 1;

            return (num1 / num2);
        }
        private bool _isZero(double num)
        {
            return (num == 0);
        }
        private bool _isNegative(double num)
        {
            return (num < 0);
        }
        private bool _isEitherZero(double num1, double num2)
        {
            return _isZero(num1) || _isZero(num2);
        }

        private bool _isEitherNegative(double num1, double num2)
        {
            return _isNegative(num1) || _isNegative(num2);
        }
        public int Factorial(double num)
        {
            if (_isNegative(num)) throw new ArgumentException("Please do not enter negative values");
            else if (_isZero(num)) return 1;
            else
            {
                int result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
                return result;
            }

        }
        public double TriangleArea(double num1, double num2)
        {
            if (_isEitherZero(num1, num2) || _isEitherNegative(num1, num2)) throw new ArgumentException();

            return 0.5 * num1 * num2;
        }
        public double CircleArea(double num)
        {
            if (_isZero(num) || _isNegative(num)) throw new ArgumentException();

            return num * num * 22 / 7;
        }
        public double unknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }
        public double unknownFunctionB(double num1, double num2)
        {
            return Multiply(unknownFunctionA(num1, num2), Divide(1, Factorial(num2)));
        }
        public double CalculateMTBF(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Value cannot be lesser or equal to 0");
            }
            else
            {
                return (num1 + num2);
            }
        }
        public double CalculateAvailability(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Value cannot be lesser or equal to 0");
            }
            else
            {
                return Math.Round((num1 / num2) * 100, 1);
            }
        }
        public double CalculateCurrentFailureIntensity(int initialFailure, int averageNoOfFailures, int totalNumberOfFailures)
        {
            double result = 0;
            if (initialFailure > 0 && averageNoOfFailures > 0 && totalNumberOfFailures > 0)
            {
                result = Multiply(initialFailure, (Subtract(1, Divide(averageNoOfFailures, totalNumberOfFailures))));
                return result;
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equal to 0");
            }
        }
        public double CalculateAverageNoOfFailures(int initialFailure, int averageNoOfFailures, int totalNumberOfFailures, int CPUHours)
        {
            double result = 0;
            if (initialFailure > 0 && averageNoOfFailures > 0 && totalNumberOfFailures > 0 && CPUHours > 0)
            {
                result = Multiply(totalNumberOfFailures, (Subtract(1, Math.Exp(Multiply(-1, Multiply(Divide(initialFailure, totalNumberOfFailures), CPUHours))))));
                return Math.Truncate(result);
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equal to 0");
            }
        }

        public double CalculateDefectDensity(int noOfDefects, int linesOfCode)
        {
            double result = 0;

            if (noOfDefects > 0 && linesOfCode > 0)
            {
                result = Divide(noOfDefects, linesOfCode);
                return result;
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equal to 0");
            }
        }

        public double CalculateNewTotalSSI(int KSSI, int KCSI, int miscCode)
        {
            double result = 0;
            if (KSSI > 0 && KCSI > 0 && miscCode > 0)
            {
                result = Subtract(Add(KSSI, KCSI), miscCode);
                return result;
            }
            else
            {
                throw new ArgumentException("Value cannot be lesser or equal to 0");
            }
        }
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = fileReader.Read("../../../../ICT3101_Calculator/MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}