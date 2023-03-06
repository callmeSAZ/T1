using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دریافت سه عدد اعشاری و گرفتن میانگین
            float x, y, z;
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            z = float.Parse(Console.ReadLine());

            float sum = x + y + z;
            float avg = sum / 3;

            Console.WriteLine("Average={0}", avg);
            Console.ReadKey();
        }
    }
}
