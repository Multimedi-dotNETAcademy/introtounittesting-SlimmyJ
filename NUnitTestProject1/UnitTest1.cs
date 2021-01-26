using NUnit.Framework;

namespace TestNinja.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            int numA = 2;
            int numB = 3;
            //ACT
            int result = numA + numB;
            //ASSERT

            Assert.AreEqual(5, result);
        }
    }
}