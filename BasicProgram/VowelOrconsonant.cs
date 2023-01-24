using System;
namespace BasicProgram
{
    public class VowelOrconsonant
    {
        public static void VowelOrConsonants()
        {
            Console.WriteLine("Input any Alphabet from (A to Z) or (a to z)");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 0 && i <= 57)
            {
                Console.WriteLine("You Entered a Number Please, Enter an Alphabet");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is Consonant");
                        break;
                }
            }
        }
    }
}
