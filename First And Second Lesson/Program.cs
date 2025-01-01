using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int Num = 123;
        int FirstOfNum = Num / 100;
        int SecondOfNum = Num / 10 % 10;
        int EndOfNum = Num % 10;
        Console.WriteLine($" Num = {Num}\n First Of Num: {FirstOfNum}\n Second Of Num: {SecondOfNum}\n End Of Num: {EndOfNum}");
    }
}