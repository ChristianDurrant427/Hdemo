using FluentAssertions;
using TechTalk.SpecFlow;

namespace Calculator


{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly Calculator _calculator = new Calculator();

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext _scenarioContext)
        {
            this._scenarioContext = _scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        private int _result;

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.FirstNumber - _calculator.SecondNumber;
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.FirstNumber * _calculator.SecondNumber;
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenAdditionIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.FirstNumber + _calculator.SecondNumber; ;
            _calculator.FirstNumber = _result;
        }

        [When(@"operation / is done to the number (.*)")]
        public void WhenDivisionIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.FirstNumber / _calculator.SecondNumber; ;
            _calculator.FirstNumber = _result;
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenSubraction_IsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.FirstNumber - _calculator.SecondNumber; ;
            _calculator.FirstNumber = _result;
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenModIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.FirstNumber % _calculator.SecondNumber; ;
            _calculator.FirstNumber = _result;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}