using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation
            FindValues values = new FindValues();

            //Getting radius from user
            Console.WriteLine("Enter your circles radius: ");
            float r = (float) Convert.ToDecimal(Console.ReadLine());

            float area = values.FindArea(r);
            float circum = values.FindCircumference(r);

            Console.WriteLine("Your circle's area is: " + area);
            Console.WriteLine("Your circle's circumference is: " +  circum);

            Console.ReadKey();
        }
    }
}
