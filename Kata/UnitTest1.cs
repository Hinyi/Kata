namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTests
{
    [Test]
    public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
    {
        Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
    }
}