using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using static System.Math;

namespace Kata;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(x => x).Where(x => x.Count() > 1).Count();
    }
}
