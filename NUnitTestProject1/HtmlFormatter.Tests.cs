using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    public class HtmlFormatterTests
    {
        public HtmlFormatter testformatter = new HtmlFormatter();

        [SetUp]
        public void SetUp()
        {
            testformatter = new HtmlFormatter();
        }

        [TestCase("I am bold", "<strong>I am bold</strong>")]
        [TestCase("I am bald", "<strong>I am bald</strong>")]
        public void HtmlFormatter_WhenCalled_ReturnCode(string input, string expectedResult)
        {
            string result = testformatter.FormatAsBold(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}