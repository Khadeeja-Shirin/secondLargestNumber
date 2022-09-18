using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 67, 8, 9, 6, 78, 90 };
            Console.WriteLine("Array is");
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Array.Sort(nums);
            Console.WriteLine("\nlargest number in array is: " + nums[nums.Length - 1]);
            Console.WriteLine("second largest number in array: " + nums[nums.Length - 2]);
            Console.ReadKey();
        }
    }
}
