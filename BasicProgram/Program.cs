using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicProgram;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Basic Program");
        Console.WriteLine("Please choose any one program");
        Console.WriteLine("1:Calculator\n2:SwitchCase\n3:Fibonacci\n4:PrimeNumber\n10:Exit");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Please enter first number");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter second number");
                int second = Convert.ToInt32(Console.ReadLine());
                Calculator calculator1 = new Calculator(first, second);
                calculator1.Addition();
                calculator1.Substaction();
                calculator1.Multiplication();
                calculator1.Division();


                Console.WriteLine("Please enter third number");
                int third = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter fourth number");
                int fourth = Convert.ToInt32(Console.ReadLine());
                Calculator calculator2 = new Calculator(third, fourth);
                calculator2.Addition();
                calculator2.Substaction();
                calculator2.Multiplication();
                calculator2.Division();
                break;

            case 2:
                Console.WriteLine("Enter the  number from 1 to 7");
                int day = Convert.ToInt32(Console.ReadLine());
                WeekDays.FindADayWhichFallsOnWeek(day);
                break;

            case 3:
                Console.Write("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                FiboNumber fibonacci = new FiboNumber(number);
                fibonacci.Fibonacci();
                break;

            case 4:
                Console.WriteLine("Enter the number to find Prime Number");
                PrimeNumber.PrimeNumb();
                break;

            case 10:
                break;

            default:
                Console.WriteLine("Please choose number 1 or 2");
                break;
                    
        }
        Console.ReadLine();
    }
}

