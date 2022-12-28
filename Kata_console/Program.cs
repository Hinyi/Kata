// See https://aka.ms/new-console-template for more information

 static int Number(List<int[]> peopleListInOut)
    {
        foreach (var i in peopleListInOut)
        {
        Console.WriteLine(i[0]);
        Console.WriteLine(i[1]);
            
        }

        return 1;
    }
 
 List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
Number(peopleList);