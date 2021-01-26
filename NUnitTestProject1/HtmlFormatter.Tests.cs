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

        [TestCase("Is this in bold", "<strong>Yes this is bold</strong>")]
        [TestCase("This is also bold", "<strong>I am very bold</strong>")]
        public void HtmlFormatter_WhenCalled_ReturnCode(string input, string expectedResult)
        {
            string result = testformatter.FormatAsBold(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}