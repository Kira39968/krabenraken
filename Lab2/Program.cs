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
            Team FirstTeam = new Team();
            Team SecTeam = new Team();

            Console.WriteLine("Если, внезапно, ссылки на объекты равны, вот тут " + FirstTeam == SecTeam + " будет тру:) ");




            Console.ReadKey();
        }
    }
}
