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
            int NumberOfElements = 0;
            Console.WriteLine("Please, enter the number of elements in one - dimensional array");
            NumberOfElements = Convert.ToInt32(Console.ReadLine());

            Paper[] ODArray = new Paper[NumberOfElements];
            for (int i = 0; i < NumberOfElements; i++)
                ODArray[i] = new Paper();

            
            Console.WriteLine("Please, enter rows and columns of two - dimensional array, using ',': ");
            string[] RowsAndColumnsTDArr = Console.ReadLine().Split(',');
            int NumberOfRowsInTDArray = int.Parse(RowsAndColumnsTDArr[0]);
            int NumberOfColumnsInTDArray = int.Parse(RowsAndColumnsTDArr[1]);
            Paper[,] TDArray = new Paper[NumberOfRowsInTDArray,NumberOfColumnsInTDArray];

            for (int i = 0; i < NumberOfRowsInTDArray; i++)
                for (int j = 0; j < NumberOfColumnsInTDArray; j++)
                    TDArray[i,j] = new Paper();


            Console.WriteLine("Please, enter rows and columns of ragged array, using ',': ");
            string[] RowsAndColumnsRaggedArr = Console.ReadLine().Split(',');
            int NumberOfColumnsInRaggedArray = int.Parse(RowsAndColumnsRaggedArr[0]);
            int NumberOfRowsInRaggedArray = int.Parse(RowsAndColumnsRaggedArr[1]);
            Paper[][] RaggedArray = new Paper[NumberOfRowsInRaggedArray][];
            for (int i = 0; i < NumberOfRowsInRaggedArray; i++)               
                    RaggedArray[i] = new Paper[NumberOfColumnsInRaggedArray];

            for (int i = 0; i < NumberOfRowsInRaggedArray; i++)
                for (int j = 0; j < NumberOfColumnsInRaggedArray; j++)
                    RaggedArray[i][j] = new Paper();

            int start = Environment.TickCount;
            for (int i = 0; i < NumberOfElements; i++)
                ODArray[i].Name = "qwe";
            int end = Environment.TickCount - start;
            Console.WriteLine("First result is: " + end);

            start = Environment.TickCount;
            for (int i = 0; i < NumberOfRowsInTDArray; i++)
                for (int j = 0; j < NumberOfColumnsInTDArray; j++)
                    TDArray[i, j].Name = "qwe";
            end = Environment.TickCount - start;
            Console.WriteLine("Second result is: " + end);

            start = Environment.TickCount;
            for (int i = 0; i < NumberOfRowsInRaggedArray; i++)
                for (int j = 0; j < NumberOfColumnsInRaggedArray; j++)
                    RaggedArray[i][j].Name = "qwe";
            end = Environment.TickCount - start;
            Console.WriteLine("Third result is: " + end);

            Console.WriteLine("\n-----------------------------------------------------\n");
            
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
