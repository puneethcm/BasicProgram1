using System;
namespace BasicProgram
{
	internal class Calculator
	{
        public int first, second, result;
        public Calculator(int firstNum, int secondNum)
        {
            first = firstNum;
            second = secondNum;
        }
        /// <summary>
        /// Addition of 2 num to get result
        /// </summary>
        public void Addition()
        {
            result = first + second;
            Console.WriteLine("Sum:" + result);
        }
    }
}

