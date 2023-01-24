using System;
namespace BasicProgram
{
	public class SwapNumber
	{
		public static void SwapTowNumber()
		{
			int number = 0;
			Console.WriteLine("Enter the First Number: ");
			int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Numbers Before Swapping ===> {0}, {1}", first, second);
            number = first;
			first = second;
			second = number;
            Console.WriteLine("Numbers After Swapping ===> {0}, {1}", first, second);
        }
	}
}

