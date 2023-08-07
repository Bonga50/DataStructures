using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    internal class ArrayTester
    {
        static void Main(string[] args)
        {
            #region
            //2d array
            int[,] arr = { { 4,7,1}, {6,8,3}, {5,2,10} };
           
           //3d array
           int[,,] arr3d = { 
                { { 4, 7, 1 },{ 4, 7, 1 },{4, 7, 1 } },
                { { 6, 8, 3 },{ 2, 5, 3 }, { 5, 8, 1 } },
                { { 6, 5, 6 }, { 2, 5, 7 }, { 4, 3, 2 } } };
            int[,] argu = populate2d();
            print2d(argu);
            print3d(arr3d);
            #endregion
            //jagged array
            string[] names = new string[] { "Ben", "Dover" };
            string[] names2 = new string[] {"Ben","Dover","Mike" };
            string[] names3 = new string[] { "Ben", "Dover", "Mike","oksmall" };

            string[][] JaggedArg = new string[3][] {names,names2,names3 };

            string[] h_Rick = new string[] { "Tennies", "Soccer" };
            string[] h_Morty = new string[] { "Soccer", "Hockey", "React" };
            string[] h_Summer = new string[3];

            string[][] JaggedHobies = new string[4][];
            JaggedHobies[0] =h_Rick; 
            JaggedHobies[1] =h_Morty;
            JaggedHobies[2] =h_Summer;
            JaggedHobies[3] = new string[] { "Swimming", "Rugby" };

            PrintJagged(JaggedArg);
            PrintJagged(JaggedHobies);
            Console.ReadLine();
        }

        //O(n)
        public static void print2d(int[,] arr) {
            Console.WriteLine("My 2d array");

            for (int i = 0; i < arr.GetLength(0); i++) //O(n)
            {
                for (int j = 0; j < arr.GetLength(1); j++) //O(n)
                {
                    Console.WriteLine($"row {i + 1} and col {j + 1} =  {arr[i, j]}"); //O(1)

                }
            }
        }

        public static void print3d(int[,,] arr) {
            Console.WriteLine("My 3d array \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int x = 0; x < arr.GetLength(2); x++)
                    {
                        Console.WriteLine($"row {i + 1} and col {j + 1} =  {arr[i, j,x]}");
                    }

                }
            }
        }

        public static void PrintJagged(string[][] JaggedArg) {
            Console.WriteLine("My Jagged Arrg");
            for (int i = 0; i < JaggedArg.Length; i++)
            {
                Console.WriteLine($"Array number {i + 1}");
                for (int j = 0; j < JaggedArg[i].Length; j++)
                {
                    Console.Write($"{JaggedArg[i][j]}, ");
                }
                Console.WriteLine("");
            }

        }

        public static int[,] populate2d() {

            int[,] arr = new int[4, 3];
            int x = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   arr[i, j] = x + 2;
                   x=x+2;
                }
            }
            return arr;
        }
    }
}
