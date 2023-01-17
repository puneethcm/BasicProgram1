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

        public void Multiplication()
        {
            result = first * second;
            Console.WriteLine("Multiply:" + result);
        }

        public void Division()
        {
            result = first / second;
            Console.WriteLine("Div:" + result);
        }

        public void Substaction()
        {
            result = Math.Abs(first - second);
            Console.WriteLine("diff:" + result);
        }
    }
}

