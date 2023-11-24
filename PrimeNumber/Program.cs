using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;

namespace task24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = GenerateNumberList(1, 1000);
            List<int> primeNumbers = GetPrimeNumbers(numbers);

            foreach(int prime in  primeNumbers)
            {
                Console.WriteLine(prime);
            }
        }

       static List<int> GenerateNumberList(int start, int end)
        {
            List<int> numbers = new List<int>();
            for(int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }
        static List<int> GetPrimeNumbers(List<int> numbers)
        {
            List<int> primeNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }
        static bool IsPrime(int number)
        {
            if(number < 2)
            {
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
