using System.Diagnostics;
using TestingWithTheDebugger;

//Testing the sum method
Debug.Assert(Calculator.Sum(5, 10) == 15, "The Sum Method didnt gave the correct result of 15.");

Console.WriteLine("Sum of ( 5 , 10 ): " + Calculator.Sum(5, 10));


//Testing the subtract method
Debug.Assert(Calculator.Subtract(20, 3) == 17, "The Subtract method didnt return the correct result of 17.");

Console.WriteLine("Subtracted Number from ( 20 - 3 ): " + Calculator.Subtract(20, 3));

Debug.Assert(Calculator.Subtract(30, 14.77) == 15.23, "The Subtract method didnt return the correct result of 15,23");

Console.WriteLine("Subtracted Number from ( 30 - 14.77 ): " + Calculator.Subtract(30, 14.77));


//Compare arrays and test it with debug.assert
int[] numbers = { 1, 2, 3, 4, 5 };

int[] CorrectResult = { 2, 4, 6, 8, 10 };

var methodResult = new Calculator().ReturnDoubleOfCollectionValues(numbers);

Debug.Assert(Enumerable.SequenceEqual(methodResult, CorrectResult),
            "The method didnt returned the correct array of numbers as 2,4,6,8,10.");

int index = 0;
Console.WriteLine("\nCorrect Result of two arrays equals\n\nnumbers\tCorrectResult");

foreach (int i in methodResult)
{
    Console.WriteLine(i + "\t {0}", CorrectResult[index]);
    index++;
}