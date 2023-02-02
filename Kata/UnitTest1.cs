using NUnit.Framework.Internal;

namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTest
{
    [TestFixture]
    public class KataTest
    {
        
        [Test]
        public void SmallNumbers()
        {
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
        }        
        [Test]
        public void SmallNumbers2()
        {
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
        }        
        [Test]
        public void SmallNumbers3()
        {
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
        }        
        [Test]
        public void SmallNumbers4()
        {
            Assert.AreEqual(441, Kata.NextBiggerNumber(414));
        }        
        [Test]
        public void SmallNumbers5()
        {
            Assert.AreEqual(414, Kata.NextBiggerNumber(144));   
        }        
        [Test]
        public void SmallNumbers6()
        {
            Assert.AreEqual(123456798, Kata.NextBiggerNumber(123456789));
        }        
        [Test]
        public void SmallNumbers7()
        {
            Assert.AreEqual(169692891, Kata.NextBiggerNumber(169692819));
        }
    }
}
