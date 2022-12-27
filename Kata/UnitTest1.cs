namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTest
{
    [Test]
    public void ShouldReturnHelloWorld()
    {
        Assert.AreEqual("hello world!", Kata.greet());
    }
}