using System;
namespace BasicProgram
{
	public class LargerNumber
	{
		public static void FindLargerNumber()
		{
            Console.WriteLine("Enter the Number to find larger number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("{0} is greter Number",a);
            else if (b > a && b > c)
                Console.WriteLine("{0} is greter Number",b);
            else
                Console.WriteLine("{0} is greater",c);
            Console.ReadLine();
        }
	}
}

