using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(2007,01,27);
            Person Hui = new Person("Hui", "Pesda", birth);
            Console.WriteLine(Hui.GetHashCode());

            birth = new DateTime(2007, 01, 27);
            Person Chmo = new Person("mmm", "Pesda", birth);
            Console.WriteLine(Chmo.GetHashCode());
            Console.WriteLine("1 " + Hui.GetHashCode());
            Console.WriteLine("2 " + Hui.GetHashCode());
            Console.WriteLine("3 " + Hui.GetHashCode());
            Console.WriteLine("4 " + Hui.GetHashCode());
            Console.ReadKey();
        }
    }
}
