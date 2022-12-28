namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class Tests
{
    [Test]
    public void Test1() {
        Assert.AreEqual("0.00", NthSeries.seriesSum(0));
    }
    [Test]
    public void Test2() {
        Assert.AreEqual("1.77", NthSeries.seriesSum(9));
    }
}