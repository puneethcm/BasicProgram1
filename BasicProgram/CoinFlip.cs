using System;
namespace BasicProgram
{
    public class CoinFlip
    {
        public static void CoinFlipCount()
        {
            int headCount = 0, tailCount = 0;
            Console.WriteLine("Enter the number of times coin to be fliped");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 1; i <= n; i++)
            {
                double number = random.NextDouble();
                if (number < 0.5)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            Console.WriteLine("Head {0} Tail {1}", headCount, tailCount);
            int headPercent = (headCount * 100) / n;
            Console.WriteLine("Head Percentage {0}%", headPercent);
            int tailPercent = (tailCount * 100) / n;
            Console.WriteLine("Head Percentage {0}%", tailPercent);
        }
    }
}