Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject2/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Multiply two numbers
	Given the first number is 20
	And the second number is 10
	When the two numbers are Multipied
	Then The result should be 200

	Scenario: Subtract two numbers
	Given the first number is 20
	And the second number is 10
	When the two numbers are Subtracted
	Then The result should be 10

	Scenario: Division two numbers
	Given the first number is 20
	And the second number is 10
	When the two numbers are Divided
	Then The result should be 02