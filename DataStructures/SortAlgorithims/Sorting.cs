using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            List<int> mylist = new List<int>()
            { 1, 15, 42, 73, 8, 56, 91, 27, 63, 5 };


            List<Student> studentList = new List<Student>() {
            new Student("John", "Doe", 20),
            new Student("Jane", "Smith", 22),
            new Student("Michael", "Johnson", 21),
            new Student("Emily", "Williams", 23),
            new Student("William", "Brown", 19),
            new Student("Ben", "Dover", 12)};


            //DisplayArray(MyArray);
            //SortMyBubbles(MyArray);
            //DisplayArray(MyArray);

            int[] MyFatArray = new int[100];
            for (int i = 0; i < MyFatArray.Length; i++)
            {
                MyFatArray[i] = RandomGen();
            }
            //DisplayArray(MyFatArray);

            //SelectMySort(MyFatArray);
            //SortMyBubbles(MyFatArray);
            SortMyBubbles(studentList);
            DisplayArray(studentList);
            

            Console.ReadLine();

        }
        /// <summary>
        /// This Is Bubble sort fuction
        /// </summary>
        /// <param name="args"></param>
        public static void SortMyBubbles(int[] args) {
            Console.WriteLine("Selection Bubble sort");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

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
            Console.WriteLine($"Elapsed time :{stopwatch.Elapsed.TotalMilliseconds}");
            stopwatch.Stop();
            

        }
        /// <summary>
        /// Buble sort method that takes a list
        /// </summary>
        /// <param name="args"></param>
        public static void SortMyBubbles(List<int> args)
        {
            Console.WriteLine("Selection Bubble sort");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (args.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            for (int i = 0; i < args.Count - 1; i++)
            {
                for (int j = (i + 1); j < args.Count; j++)
                {
                    if (args[j] < args[i])
                    {
                        int temp = args[j];
                        args[j] = args[i];
                        args[i] = temp;
                    }
                }

            }
            Console.WriteLine($"Elapsed time :{stopwatch.Elapsed.TotalMilliseconds}");
            stopwatch.Stop();


        }
        /// <summary>
        /// Method to sort students by age
        /// </summary>
        /// <param name="args"></param>
        public static void SortMyBubbles(List<Student> args)
        {
            Student temp;
            Console.WriteLine("Bubble sort");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (args.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            for (int i = 0; i < args.Count-1; i++)
            {
                for (int j = (i+1); j < args.Count; j++)
                {
                    if (args[j].Age < args[i].Age)
                    {
                         temp = args[j];
                        args[j] = args[i];
                        args[i] = temp;
                    }
                    temp = null;
                }

            }
            Console.WriteLine($"Elapsed time :{stopwatch.Elapsed.TotalMilliseconds}");
            stopwatch.Stop();


        }

        /// <summary>
        /// Method to display an array
        /// </summary>
        /// <param name="arg"></param>
        public static void DisplayArray(int[] arg) {
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write(arg[i]+ " ");
            }

            Console.WriteLine("");
        }
        /// <summary>
        /// Metod to display list of integers
        /// </summary>
        /// <param name="arg"></param>
        public static void DisplayArray(List<int> arg)
        {
            for (int i = 0; i < arg.Count; i++)
            {
                Console.Write(arg[i] + " ");
            }

            Console.WriteLine("");
        }
        /// <summary>
        ///  Method to display student objects  
        /// </summary>
        /// <param name="arg"></param>
        public static void DisplayArray(List<Student> arg)
        {
            for (int i = 0; i < arg.Count; i++)
            {
                Console.Write(arg[i].ToString() + "\n");
            }

            Console.WriteLine("");
        }


        /// <summary>
        /// Method to generate random numbers
        /// </summary>
        /// <returns></returns>
        public static int RandomGen() {
            
            int x = xRan.Next(1,500);
            return x;

        }
        /// <summary>
        /// Selection sort method
        /// </summary>
        /// <param name="arg"></param>
        public static void SelectMySort(int[] arg)
        {
            Console.WriteLine("Selection sort");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (arg.Length == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            for (int i = 0; i < arg.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = (i + 1); j < arg.Length; j++)
                {
                    if (arg[j] < arg[minIndex])
                    {
                        minIndex = j;
                       
                    }
                }
                int temp = arg[minIndex];
                arg[minIndex] = arg[i];
                arg[i] = temp;
                
            }
            Console.WriteLine($"Elapsed time :{stopwatch.Elapsed.TotalMilliseconds}");
            stopwatch.Stop();
            
            

        }
        /// <summary>
        /// Insertion sort method
        /// </summary>
        /// <param name="args"></param>
        public static void InsertionSort(int[] args) {
            Console.WriteLine("Insertion sort");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (args.Length == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            for (int i = 0; i < args.Length - 1; i++)
            {
                for (int j = (i+1); j > 0; j--)
                {
                    if (args[j-1] > args[j])
                    {
                        int temp = args[j - 1];
                        args[j-1] = args[j];
                        args[j] = temp;
                    }
                }

            }
        }
           


    }
}
