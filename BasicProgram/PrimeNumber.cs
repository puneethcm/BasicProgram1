using System;
namespace BasicProgram
{
	public class PrimeNumber
	{
		public static void PrimeNumb()
		{
            Console.Write("Enter The Start Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime Numbers between {firstNumber} and {secondNumber} are : ");
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    
	}
}

