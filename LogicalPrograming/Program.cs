using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    class Program  //Array maximum and minimum number
    {
        static void Main(string[] args)
        {

            int max, min;
            
            
            
            Console.WriteLine("Entre the Length of Array");
            int s = int.Parse(Console.ReadLine());

            int[] arr;
            arr = new int[s];
            max = arr[0];

            for (int i = 0; i < s; i++)
            {
                Console.Write("Element {0}", i + " ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements in aray are ");

            for (int i = 0; i < s; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Maximun number in array are");
            for (int i = 0; i < s; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum number is : {0}", max);
            Console.WriteLine("minimum number in array are");

            min = arr[0];
            for (int i = 0; i < s; i++)
            {

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum number is : {0}", min);

            Console.ReadLine();
        }
    }
}
