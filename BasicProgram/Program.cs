using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicProgram;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Basic Program");
        Console.WriteLine("Please choose any one program");
        Console.WriteLine("1:Calculator\n2:SwitchCase\n3:Fibonacci\n4:PrimeNumber\n5:Coin Flip\n6:Swap two numbers" +
                           "\n7:Enen and odd numbers\n8:To Fine Number is Prime or Not\n9:Vowels or Consonant\n10:Leap Year" +
                           "\n11:Harmonic Numbers\n:12:Fotorial");
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
                Console.WriteLine("Enter the number to find Prime Numbers");
                PrimeNumber.PrimeNumb();
                break;

            case 5:
                Console.WriteLine("Welcome to coin flip program");
                CoinFlip.CoinFlipCount();
                break;
            case 6:
                Console.WriteLine("Welcome to Swap two numbers program");
                SwapNumber.SwapTowNumber();
                break;
            case 7:
                Console.WriteLine("Welcone to even and odd program");
                EvenOddNumbers.EvenAndOddNumbers();
                break;

            case 8:
                Console.WriteLine("Welcome to Prime Number");
                PrimeNumbers.PrimeNumber();
                break;
            case 9:
                Console.WriteLine("Check weather the input Alphabet is Vowel or Consonant");
                VowelOrconsonant.VowelOrConsonants();
                break;

            case 10:
                LeapYear.FindLeapYear();
                break;
            case 11:
                HarmonicNumbers.FindHarmonicNumbers();
                break;
            case 12:
                Factorial.FindFactorial();
                break;

            default:
                Console.WriteLine("Please choose number 1 or 2");
                break;
                    
        }
        Console.ReadLine();
    }
}

