namespace Kata;

using NUnit.Framework;
using System;


[TestFixture]
public class Tests
{
    [Test]
    public void Test1 () {
        string[] expected = { "Ryan", "Mark" };
        string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
        CollectionAssert.AreEqual (expected, Kata.FriendOrFoe (names));
    }
}