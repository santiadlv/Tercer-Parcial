using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3_P2.Clases;

namespace Parcial3_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 7, 9, 4, 6, 8 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i].ToString());
            }

            NormalClass.insertionSort(nums, 5);
            Console.WriteLine();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i].ToString());
            }

            Console.ReadKey();
            Console.Clear();

            string[] words = { "doggo", "cat", "turtle", "elephant", "bird" };
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            GenericClass.insertionSort(words, 5);
            Console.WriteLine();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadKey();
        }
    }
}
