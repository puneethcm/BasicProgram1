﻿namespace BasicProgram;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Basic Program");
        Console.WriteLine("Please enter first number");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        int second = Convert.ToInt32(Console.ReadLine());
        Calculator calculator = new Calculator(first, second);
        calculator.Addition();
        Console.ReadLine();
    }
}

