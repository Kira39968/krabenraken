using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam DyatlovTeam = new ResearchTeam("Pereval", "Dyatlov Team", 6845312, TimeFrame.Year);
            Console.WriteLine(DyatlovTeam.ToShortString());

            Console.WriteLine();
            Console.WriteLine(DyatlovTeam[TimeFrame.Year]);
            Console.WriteLine(DyatlovTeam[TimeFrame.TwoYears]);

            DyatlovTeam.ResearchPublications = new Paper[]{new Paper()};
            Person Dyatlov = new Person("Igor", "Dyatlov", new DateTime(1936, 01, 13));
            Paper p1 = new Paper("Taina", Dyatlov, new DateTime(1959, 02, 02));
            Paper p2 = new Paper("Taina2", Dyatlov, new DateTime(1960, 02, 03));

            DyatlovTeam.AddPapers(p1, p2);
            Console.WriteLine(DyatlovTeam.ToShortString());

            

            Console.ReadKey();
        }
    }
}
