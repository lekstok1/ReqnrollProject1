using Allure.Net.Commons;
using NUnit.Framework;
using Reqnroll;
using ReqnrollProject1.Models;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            
            _scenarioContext = scenarioContext;
        }
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        [StepArgumentTransformation(@"in (\d+) days?")]
        public DateTime InXDaysTransform(int days)
        {
            return DateTime.Today.AddDays(days);
        }

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            AllureApi.Step($"Getting first number {number}");
            _scenarioContext["firstNumber"] = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            AllureApi.Step($"Getting second number {number}");
            _scenarioContext["secondNumber"] = number;
        }

        [Given(@"my new (\d+) number")]
        public void GivenNUmber(string number)
        {
            _scenarioContext["new"] = number;
        }/*

        [When(@"meeting in (\d+) days?")]
        public void WhenMeeting(DateTime time)
        {
            _scenarioContext["new1"] = time;
        }*/

        [Given("I get list of users")]
        public void GivenGetUsrList(DataTable dataTable)
        {
            List<User> users = dataTable.CreateSet<User>().ToList();

            foreach (User user in users) { 
                Console.WriteLine(user.FirstName);
            }
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            AllureApi.AddAttachment(
           "download.jfif",
           "image/jpeg",
           File.ReadAllBytes("download.jfif")
       );
            int firstNumber = _scenarioContext.Get<int>("firstNumber");
            int secondNumber = _scenarioContext.Get<int>("secondNumber");
            _scenarioContext["result"] = firstNumber + secondNumber;
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            var  dsfd = _scenarioContext.ScenarioInfo;
            Assert.That(result, Is.EqualTo(_scenarioContext.Get<int>("result")));
        }
    }


}
