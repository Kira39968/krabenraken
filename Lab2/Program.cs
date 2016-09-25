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
            Team ф = new Team();
            Team и = new Team();

            Console.WriteLine("Если, внезапно, ссылки на объекты равны, то вот тут >>" 
                + ReferenceEquals(ф, и) + "<< будет тру:) ");

            Console.WriteLine("Если, внезапно, объекты не равны, то вот тут >>"
                + ф.Equals(и) + "<< будет фолс:) ");


            Console.ReadKey();
        }
    }
}
