using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Using_Lists
{
    public class ListTester
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2,4,6};
            Console.WriteLine("First test");
           nums.Add(7);
           nums.Insert(2, 5);
            feaculMatter(nums);
             Console.WriteLine("Second test");

            nums.Insert(0, 1);
            feaculMatter(nums);


            Console.WriteLine("Third test");
            nums.RemoveAt(nums.Count-2);
            feaculMatter(nums);
            Console.WriteLine("Sum :"+ SumOf(nums));

            Console.ReadLine();
        }

        public static int SumOf(List<int> nums) {

            int result = 0;
            result = nums.Sum();
            return result; 
        }
        public static void feaculMatter(List<int> nums) {
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
