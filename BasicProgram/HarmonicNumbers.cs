using System;
namespace BasicProgram
{
	public class HarmonicNumbers
	{
		public static void FindHarmonicNumbers()
		{
			double harmonicSum = 0;
			Console.WriteLine("\nWelcome to Harmonic number program");
			Console.WriteLine("\nEnter th number");
			int n = Convert.ToInt32(Console.ReadLine());

			for (double i = 1; i <= n; i++)
			{
                Console.Write("1/{0} + ", i);
				harmonicSum = harmonicSum + (1 / i);
            }
            Console.Write("\nSum of harmonic Value upto {0} is {1}",n , harmonicSum);
        }
	}
}

