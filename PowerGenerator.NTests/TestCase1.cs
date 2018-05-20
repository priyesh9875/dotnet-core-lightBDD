using System;
using NUnit.Framework;

namespace PowerGenerator.NTests
{
    [TestFixture]
    [Category("SetUp")]
    public class TestCase1
    {

        [TestCase]
        public void AddTest()
        {
            Plant plant = new Plant("plant1");
            Assert.IsNotNull(plant);
        }

    }
}
