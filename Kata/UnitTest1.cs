namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
        Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));      
        Assert.AreEqual(2, Kata.FindShort("Let's travel abroad shall we"));
    }
}