
using NUnit.Framework;
using System;

namespace test47
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            var sum = Sum.Calculate(1, 2);
            Assert.AreEqual(sum, 5);
        }

    }
}
