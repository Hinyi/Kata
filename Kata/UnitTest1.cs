namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class SolutionTest
{
    private static int[][][] matrix =
    {
        new int[][] { new [] { 1 } },
        new int[][] { new [] { 1, 3 }, new [] { 2, 5 } },
        new int[][] { new [] { 2, 5, 3 }, new [] { 1, -2, -1 }, new [] { 1, 3, 4 } }
    };

    private static int[] expected = { 1, -1, -20 };

    private static string[] msg = { "Determinant of a 1 x 1 matrix yields the value of the one element", "Should return 1 * 5 - 3 * 2 == -1 ", "" };

    [Test]
    public void SampleTests()
    {
        Assert.AreEqual(expected[0], Matrix.Determinant(matrix[0]), msg[0]);
    }    
    [Test]
    public void SampleTests1()
    {
        Assert.AreEqual(expected[1], Matrix.Determinant(matrix[1]), msg[1]);
    }    
    [Test]
    public void SampleTests2()
    {
        Assert.AreEqual(expected[2], Matrix.Determinant(matrix[2]), msg[2]);
    }
}