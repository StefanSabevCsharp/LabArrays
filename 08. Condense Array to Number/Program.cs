﻿using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
                       // 1 2 3 4

            for (int i = 0; i < numbers.Length -1; i++)
            {
                for (int j = 0; j < numbers.Length - i  -1; j++)
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                    
                    
                }
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
