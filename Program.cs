/* 
Name:         Roger Silva Santos Aguiar
Function:     It tryies the BinaryNumbers.cs 
Initial date: January 27, 2021 
Last update:  January 27, 2021 
*/
using System;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryNumber add = new BinaryNumber();

            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            string result = BinaryNumber.AddBinary(firstNumber, secondNumber);

            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        }
    }
}
