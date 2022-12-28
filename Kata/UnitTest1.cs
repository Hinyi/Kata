namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class Testsa
{
    private Kata variabonacci;
  
    [SetUp]
    public void SetUp() 
    {
        variabonacci = new Kata();
    }

    [TearDown]
    public void TearDown()
    {
        variabonacci = null;
    }

    [Test]
    public void Tests()
    {
        Assert.AreEqual(new double []{1,1,1,3,5,9,17,31,57,105}, variabonacci.Tribonacci(new double []{1,1,1},10));
        Assert.AreEqual(new double []{0,0,1,1,2,4,7,13,24,44}, variabonacci.Tribonacci(new double []{0,0,1},10));
        Assert.AreEqual(new double []{0,1,1,2,4,7,13,24,44,81}, variabonacci.Tribonacci(new double []{0,1,1},10));
    }
}