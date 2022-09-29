Feature: UsingCalculatorFactorial
In order to conquer factorials
As a factorials enthusiast
I want to understand a variety of factorial operations
@Factorial
Scenario: Factorial for zero
	Given I have a calculator
	When I have entered 6 into the calculator and press factorial
	Then the factorial result should be 720

@Factorial
Scenario: Factorial with positive number
	Given I have a calculator
	When I have entered 0 into the calculator and press factorial
	Then the factorial result should be 1

@Factorial
Scenario: Factorial with negative number
	Given I have a calculator
	When I have entered -1 into the calculator and press factorial
	Then the error 'Please do not enter negative values' should be displayed