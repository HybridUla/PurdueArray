using System.Collections;
using System.Data;

namespace PurdueArray
{
    internal class Program
    {
        static void Main()
        {
            //**
            //IN255M1 ASSESSMENT PART 2 SEC. 1
            //**

            string[,] salesRegion = new string[4, 4]
            {
                   { "North", "South", "East", "West" },
                   { "Bob", "Sue", "Nathan", "Wanda" },
                   { "Stef", "Janice", "Henry", "Charles" },
                   { "Ron", "Will", "Kimmy", "Pete" }
            };

            Console.WriteLine("Section 1: 2 Dimensional Array\n");
            for (int row= 0; row < 4; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    Console.WriteLine(salesRegion[row, col] + "\n");
                }
            }
            part2();
        }
        static void part2()
        {
            //**
            //IN255M1 ASSESSMENT PART 2 SEC. 2
            //**

            ArrayList SalesTeam = new ArrayList();


            SalesTeam.Add("Bob");
            SalesTeam.Add("Stef");
            SalesTeam.Add("Ron");

            Console.WriteLine("Section 2: ArrayList\n");
            Console.WriteLine("There are " + SalesTeam.Count + " names in the Sales Team Array\n");

            if (SalesTeam.Contains("Stef"))
            {
                Console.WriteLine("Stef is in the Array List.\n");
            }
            else
            {
                Console.WriteLine("Stef is not in the Array List.\n");
            }



            SalesTeam.Add("Sue");
            SalesTeam.Add("Janice");
            SalesTeam.Add("Will");

            Console.WriteLine("There are " + SalesTeam.Count + " names in the Sales Team Array.\n");

            SalesTeam.Remove("Janice");
            SalesTeam.Remove("Ron");

            Console.WriteLine("There are " + SalesTeam.Count + " names in the Sales Team Array.\n");


            Console.WriteLine("The Array Currently has these names:\n");
            foreach (string name in SalesTeam)
            {
                Console.WriteLine(name + "\n");
            }
        }
    }
}