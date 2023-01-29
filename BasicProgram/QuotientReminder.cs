using System;
namespace BasicProgram
{
	public class QuotientReminder
	{
		public static void FindQuotientReminder()
		{
            Console.WriteLine("Enter the divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("Divident:{0} Divisor:{1}", divident, divisor);
            Console.WriteLine("Quotient=:" + quotient);
            Console.WriteLine("Remainder=:" + remainder);
            Console.ReadLine();
        }
	}
}

