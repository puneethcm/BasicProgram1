using System;
namespace BasicProgram
{
	public class FiboNumber
	{
		int number;
		//parameter constrctor
		public FiboNumber(int firstNumb)
		{
			number = firstNumb;
		}
		public void Fibonacci()
		{
			int n1 = 0, n2 = 1, n3, i;
            Console.Write("Fibonacci Numbers are: ");
			Console.Write(n1 + "" + n2 + "");
            for (i = 2; i < number; i++)
			{
				n3 = n1 + n2;
				Console.Write(n3 + "");
				//initializing n1 value to n2
				n1 = n2;
				n2 = n3;
			}
		}
	}
}

