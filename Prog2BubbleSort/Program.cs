using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rnd = new Random();
            int temp = 0;

            // fill up the array with random numbers
            for(int x = 0; x < nums.Length; x++)
                nums[x] = rnd.Next(50);

            // display before
            Console.WriteLine("Number set before sorting...");
            foreach(int num in nums)
                Console.Write(num + "\t");

            Console.WriteLine();

            // Bubble sort

            // dictates the number of passes
            for(int x = 0; x < nums.Length; x++)
            {
                for(int y = 0; y < nums.Length - 1; y++)
                {
                    if (nums[y] > nums[y + 1])
                    {
                        temp = nums[y];
                        nums[y] = nums[y + 1];
                        nums[y + 1] = temp;
                    }

                    Console.Write("Pass " + x + " : ");
                    foreach (int num in nums)
                        Console.Write(num + "\t");
                    Console.WriteLine();
                }

            }

            // display after
            Console.WriteLine("Number set after sorting...");
            foreach (int num in nums)
                Console.Write(num + "\t");

            Console.ReadKey();
        }
    }
}
