using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write numerator:");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Write denominator:");
            int den=int.Parse(Console.ReadLine());
           
            int numeratorSum = GetDigitSum(num);
            int denominatorSum = GetDigitSum(den);

            int numeratorResult = num - numeratorSum;
            int denominatorResult = den - denominatorSum;

            Console.WriteLine($"{numeratorResult}/{denominatorResult}");
        }

        static int GetDigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
    }

