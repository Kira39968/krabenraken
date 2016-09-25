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
            Team a = new Team();
            Team b = new Team();

            Console.WriteLine("Если, внезапно, ссылки на объекты равны, то вот тут >>" 
                + ReferenceEquals(a, b) + "<< будет тру:) ");

            Console.WriteLine("Если, внезапно, объекты не равны, то вот тут >>"
                + a.Equals(b) + "<< будет фолс:) ");

            Console.Write("Тест на присваивание отрицательных значений: ");
            try
            {             
                a.RegNumber = int.Parse(Console.ReadLine());
            }
            catch(ArgumentOutOfRangeException AE)
            {
                Console.WriteLine(AE.Message);              
            }

            ResearchTeam c = new ResearchTeam();
            Person person = new Person("Sting", "Shape", DateTime.Now);
            c.AddMembers(new Person(), person);
            c.AddPapers(new Paper(), new Paper("Kosmos", person, DateTime.Now));

            Console.WriteLine(c.ToString() + "\n\n\n");


            ResearchTeam cpTeam = (ResearchTeam)c.DeepCopy();

            c.RegNumber = 23423;
            c.AddMembers(new Person("qqq", "Shape", DateTime.Now));

            Console.WriteLine("Base RT: " + c.ToString() + "\n\n\n");
            Console.WriteLine("Copy RT: " + cpTeam.ToString());



           


            Console.ReadKey();
        }
    }
}
