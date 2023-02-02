using NUnit.Framework.Internal;

namespace Kata;

using NUnit.Framework;
using System;



    [TestFixture]
    public class KataTest
    {
        
        [Test]
        public void SnailTest1()
        {
            int[][] array = new int[3][]
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Test(array, r);
        }        
        [Test]
        public void SnailTest2()
        {
            int[][] array = new int[][]
            {
                new int[]{},
                new int[]{},
                new int[]{}
            };
            var r = new int[] {};
            Test(array, r);
        }

        public string Int2dToString(int[][] a)
        {
            return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
        }

        public void Test(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            Assert.AreEqual(result, Kata.Snail(array));
        }
    }

