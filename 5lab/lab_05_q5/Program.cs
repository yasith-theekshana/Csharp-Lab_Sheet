using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            ArrMethods arrMethods = new ArrMethods();
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter value for index "+ i + ":");
                arr[i]= Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Maximum Value: "+arrMethods.Max(arr));
            Console.WriteLine("Minimum Value: "+arrMethods.Min(arr));
            Console.WriteLine("Average Value: "+arrMethods.Avg(arr));

        }
    }
}
