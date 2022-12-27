using System.Data;
using System;


namespace Kata;

public static class Kata {
    public static IEnumerable<string> FriendOrFoe (string[] names)
    {
        return names.Where(x => x.Length < 5).ToList();
    }
}