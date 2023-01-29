using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicProgram
{
    public class PowerOfTwo
    {
        public static void FindPowerOfTwo()
        {
            int bNum = 2;
            int result, pwr;
            Console.Write(" Enter the number : ");
            pwr = Convert.ToInt32(Console.ReadLine());
            result = CalcuOfPower(bNum, pwr);
            Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bNum, pwr, result);
        }
        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
    }
}

