using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PowerGenerator.NTests
{
    [TestFixture]
    [Category("LightUp")]
    public class TestCase2
    {

        [TestCase]
        public void AddTest()
        {
            Plant powerPlant = new Plant("plant2");
            foreach (var i in Enumerable.Range(0, 10))
                powerPlant.AddGenerator(new Generator(i, string.Format($"Generator {i}")));

            
            Assert.IsTrue(powerPlant.LightUpHouse(15));
        }

    }
}
