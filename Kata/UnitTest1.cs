namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTest
{
    [Test]
    public static void test1() 
    {
        Console.WriteLine("Testing PrinterError");
        string s="aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
        Assert.AreEqual("3/56", Printer.PrinterError(s));
    }
}