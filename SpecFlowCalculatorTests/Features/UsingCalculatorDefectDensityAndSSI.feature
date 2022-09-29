Feature: UsingCalculatorDefectDensityAndSSI
	In order to calculate the defect density and new total SSI
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@DefectDensity
Scenario: Calculating defect density
	Given I have a calculator
	When the total number of defects is 10 and the number of KLOC is 5 and press defect density
	Then the defect density is 2

@NewTotalSSI
Scenario: Calculate new total SSI
	Given I have a calculator
	When the number of KSSI is 50 and the number of KCSI is 20 and the number of deleted/changed code is 4 and press SSI
	Then the new total SSI is 66

