using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    internal class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()

        {
            _math = new Math();
        }

        //test methods usually follow this convention
        // MethodName_Scenario_ExpectedResult
        // GivenTheseArguments_WhenMethodCalled_ThenExpectedResult
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(4, 4, 4)]
        public void Max_WhenCalled_ReturnBiggerNumber(int numA, int numB, int expectedResult)
        {
            //ACT / When
            int result = _math.Max(numA, numB);

            //ASSERT / Then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetOddNumber_WhenGivenLimitHigherThanZero_ReturnOddNumber()
        {
            var expectedResult = new[] { 1, 3, 5 };
            IEnumerable<int> result = _math.GetOddNumbers(5);

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual(expectedResult, result);
        }
    }
}