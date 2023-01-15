namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTest
{
    [Test]
    public void EmptyTest()
    {
        Assert.AreEqual("", Kata.UniqueInOrder(""));
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
    }
}