using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortAlgorithims
{
    internal class Sorting
    {
        public static Random xRan = new Random();
        static void Main(string[] args)
        {
            int[] MyArray=new int[10] { 1, 15, 42, 73, 8, 56, 91, 27, 63, 5 };
            DisplayArray(MyArray);
            SortMyBubbles(MyArray);
            DisplayArray(MyArray);

            int[] MyFatArray = new int[100];
            for (int i = 0; i < MyFatArray.Length; i++)
            {
                MyFatArray[i] = RandomGen();
            }
            DisplayArray(MyFatArray);
            Console.ReadLine();

        }
        /// <summary>
        /// This Is Bubble so
        /// </summary>
        /// <param name="args"></param>
        public static void SortMyBubbles(int[] args) {
            if (args.Length==0)
            {
                Console.WriteLine("Empty");
                return;
            }

            for (int i = 0; i < args.Length-1; i++)
            {
                for (int j = (i+1); j < args.Length; j++)
                {
                    if (args[j] < args[i])
                    {
                        int temp = args[j];
                        args[j] = args[i];
                        args[i] = temp;
                    }
                }

            }
        
        }

        public static void DisplayArray(int[] arg) {
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write(arg[i]+ " ");
            }

            Console.WriteLine("");
        }

        public static int RandomGen() {
            
            int x = xRan.Next(1,500);
            return x;

        }

           


    }
}
