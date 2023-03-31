using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWithTheDebugger
{
    public class Calculator
    {
        public static double Sum(double num1,double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1,double num2)
        {
            return num1 - num2;
        }

        public int[] ReturnDoubleOfCollectionValues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 2;
            }

            return array;
        }
    }
}
