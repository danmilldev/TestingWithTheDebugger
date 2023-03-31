﻿using System.Diagnostics;
using TestingWithTheDebugger;


Debug.Assert(Calculator.Sum(5, 10) == 15, "The Sum Method didnt gave the correct result.");

Console.WriteLine("Sum of ( 5 , 10 ): " + Calculator.Sum(5,10));

Debug.Assert(Calculator.Subtract(20, 3) == 17, "The Subtract method didnt return the correct result.");

Console.WriteLine("Subtracted Number from ( 20 - 3 ): " + Calculator.Subtract(20,3));