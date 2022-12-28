// See https://aka.ms/new-console-template for more information

var s = "sokos";

var palindrom = new string(s.ToArray().Reverse().ToArray());

var AreEqual = s.Equals(palindrom);

Console.WriteLine($"{AreEqual}");
