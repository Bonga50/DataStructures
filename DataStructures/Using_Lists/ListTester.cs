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
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Second test");

            nums.Insert(0, 1);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Third test");
            nums.RemoveAt(nums.Count-2);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sum :"+ SumOf(nums));

            Console.ReadLine();
        }

        public static int SumOf(List<int> nums) {

            int result = 0;
            result = nums.Sum();
        return result; 
        }
    }
}
