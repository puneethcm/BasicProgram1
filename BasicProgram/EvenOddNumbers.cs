using System;
namespace BasicProgram
{
	public class EvenOddNumbers
	{
		public static void EvenAndOddNumbers()
		{
			int[] evenNumber = new int[50];
			int[] oddNumber = new int[50];
			int evenIndex = 0, oddIndex = 0;

			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					evenNumber[evenIndex] = i;
					evenIndex++;
				}
				else
				{
					oddNumber[oddIndex] = i;
					oddIndex++;
				}
            		}
            		Console.WriteLine("\nEven numbers from range 1 to 100");
			for (int j = 0; j < evenNumber.Length; j++)
			{
				Console.Write(evenNumber[j] + " ");
			}
            		Console.WriteLine("\n\nOdd numbers from range 1 to 100");
            		for (int j = 0; j < oddNumber.Length; j++)
			{
                		Console.Write(oddNumber[j] + " ");
            		}
        	}
	}
}

