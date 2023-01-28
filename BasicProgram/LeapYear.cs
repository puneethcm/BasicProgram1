using System;
namespace BasicProgram
{
	public class LeapYear
	{
		public static void  FindLeapYear()
		{
			int year;
			Console.WriteLine("Check whather the enter year is leap or not");
			Console.WriteLine("Input an year");
			year = Convert.ToInt32(Console.ReadLine());

            if (year>=1000 && year < 10000)
			{
                if ((year % 400) == 0)
                    Console.WriteLine("{0} is a leap year.\n", year);
                else if ((year % 100) == 0)
                    Console.WriteLine("{0} is not a leap year.\n", year);
                else if ((year % 4) == 0)
                    Console.WriteLine("{0} is a leap year.\n", year);
                else
                    Console.WriteLine("{0} is not a leap year.\n", year);
            }
            else
            {
                Console.WriteLine("Enter 4 digit number");
            }
        }
    }
}

