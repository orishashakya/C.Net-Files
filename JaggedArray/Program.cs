using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration and initalization
            int[][] jaggedarray = new int[4][];

            //Array {0,1,2,3}
            //JaggedArray {0{0,1,2},1{0,1,2},2{0,1,2}}

            jaggedarray[0] = new int[] { 1, 2, 3 };
            jaggedarray[1] = new int[] { 4, 5, 6, 7 };
            jaggedarray[2] = new int[] { 8 };
            jaggedarray[3] = new int[] { 9, 10 };


            Console.WriteLine("First Jagged Array");
            Console.WriteLine(jaggedarray[0][2]);
            Console.WriteLine(jaggedarray[1][1]);
            Console.WriteLine(jaggedarray[2][0]);

            int[][] jaggedarray2 = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {6,7},
                new int[] {8,9,10},
                new int[] {11,12,13,14,15,16,17,18,19,20},
            };


            Console.WriteLine("Second Jagged Array");
            Console.WriteLine(jaggedarray[0][2]);
            Console.WriteLine(jaggedarray[1][1]);
            Console.WriteLine(jaggedarray[2][0]);


            Console.WriteLine("For LOOP iterate Second Jagged Array");
            //iterate through 2nd jagged array
            for (int i = 0 ; i < jaggedarray2.Length; i++)
            {
                Console.WriteLine($"Im index {i}");
                for(int j=0;j < jaggedarray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedarray2[i][j]);
                }
            }
        }
    }
}
