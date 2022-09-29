Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@BasicReliability
Scenario: Calculating current failure intensity
	Given I have a calculator
	When the initial failure intensity is 10 and the average number of failures is 50 and the total number of failure over infinite time is 100 and press current failure intensity
	Then the current failure intensity should be 5

@BasicReliability
Scenario: Calculating average number expected of failures
	Given I have a calculator
	When the initial failure intensity is 10 and the average number of failures is 50 and the total number of failure over infinite time is 100 and the number of CPU hours is 10 and press average number of failures
	Then the average number of failures expected should be 63