using NUnit.Framework;

namespace TestNinja.Tests
{
    internal class FizzBuzz
    {
        [SetUp]
        public void SetUp()

        {
        }

        //test methods usually follow this convention
        // MethodName_Scenario_ExpectedResult
        // GivenTheseArguments_WhenMethodCalled_ThenExpectedResult
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 5)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("2", 2)]
        public void GivenNumberDividableBy3_ResultEquals_Fizz(string expectedResult, int intA)
        {
            //ARRANGE

            //ACT
            string result = Fundamentals.FizzBuzz.GetOutput(intA);
            //ASSERT

            Assert.AreEqual(expectedResult, result);
        }
    }
}