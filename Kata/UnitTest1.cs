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
        public void BasicTests()
        {
            Assert.AreEqual("a", Kata.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", Kata.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", Kata.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("", Kata.FirstNonRepeatingLetter(""));
            Assert.AreEqual("", Kata.FirstNonRepeatingLetter("moom"));
        }    
    }
}
