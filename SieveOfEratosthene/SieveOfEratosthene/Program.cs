using System;

namespace SieveOfEratosthene
{
    /// <summary>
    /// This program solves the Sieve of Eratosthenes algorithm(finding prime numbers)
    /// </summary>
    
    class Program
    {
        private static bool[] allNumbers;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 'n': ");

            var n = Convert.ToInt32(Console.ReadLine());
            var arrSize = n + 1;
            
            Console.WriteLine("-----------------------");
            
            CreateArray(arrSize);
            Sieve(arrSize);
            
        }
        
        /// <summary>
        /// Iterating through the numbers
        /// </summary>
        /// <param name="n"></param>
        
        static void Sieve(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (allNumbers[i])
                {
                    for (int c = i; i * c < n; c++)
                    {
                        allNumbers[i * c] = false;
                    }
                }
            }
            var counter = 0;
            for (int i = 2; i < n; i++)
            {
                if (allNumbers[i])
                {
                    Console.WriteLine(i + " ");
                    counter++;
                }

                if (counter == 10)
                {
                    Console.WriteLine("\n");
                    counter = 0;
                }
            }
        }
        
        /// <summary>
        /// Initialized Array
        /// </summary>
        /// <param name="n"></param>
        
        static void CreateArray(int n)
        {
            allNumbers = new bool[n];

            for (int i = 0; i < n; i++)
            {
                allNumbers[i] = true;
            }
        }
    }
}