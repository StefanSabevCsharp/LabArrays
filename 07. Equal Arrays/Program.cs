using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers1 = Console.ReadLine();
            string numbers2 = Console.ReadLine();

            int[] array1 = numbers1.Split().Select(int.Parse).ToArray();
            int[] array2 = numbers2.Split().Select(int.Parse).ToArray();

            int totalSum = 0;
            bool flag = true;
            
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    totalSum += array1[i];
                }
                else if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    flag = false;
                    break;
                }

            }
            if (flag)
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            }

        }
    }
}
