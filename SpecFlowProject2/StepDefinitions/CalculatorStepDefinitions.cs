using SpecFlowProject2;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {

            calculator.Fnum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.Snum = number;

        }

        [When("the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Multiply();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }
        [When("the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calculator.Subtract();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBesub(int result)
        {
            result.Should().Be(result);
        }
        [When("the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Division();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBediv(int result)
        {
            result.Should().Be(result);
        }
    }
}
