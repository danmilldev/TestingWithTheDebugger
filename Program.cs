using System.Diagnostics;
using TestingWithTheDebugger;


Debug.Assert(Calculator.Sum(5, 10) == 15, "The Sum Method didnt gave the correct result");

Console.WriteLine("Sum: " + Calculator.Sum(5,10));