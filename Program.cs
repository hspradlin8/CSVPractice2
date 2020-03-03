using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MonsterCSV
{
    class Program
    {

        static void Main(string[] args)
        {
            //pulling the files from the filePath and reading the CSV files
            string filePath = @"/Users/Heidi/Downloads/two copy.csv";

            //Step 1: how to access the data from the text file to populate a list of monsters

            List<Monster> monsters = new List<Monster>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Monster newMonster = new Monster();

                newMonster.TimeStamp = entries[0];
                newMonster.Researcher = entries[1];
                newMonster.MonsterName = entries[2];
                newMonster.Latitude = entries[3];
                newMonster.Longitude = entries[4];

                monsters.Add(newMonster);

                int[] terms = new int[4];
                for (int runs = 0; runs < terms.Length; runs++)
                {
                    terms[runs] = entries.Length;
                }
            }
            Console.WriteLine("Read from text files");

            // creating a new entrie based on the split apart entries 
            foreach (var monster in monsters)
            {
                Console.WriteLine($"{ monster.TimeStamp } { monster.Researcher } { monster.MonsterName } { monster.Latitude } { monster.Longitude }");
            }

            // adding a new monster to my monster array

            monsters.Add(new Monster { TimeStamp = "2020-3-2 12:30:15", Researcher = "Frank", MonsterName = "Frankenstien", Latitude = "48.689912", Longitude = "-115.611383" });

            List<string> output = new List<string>();

            foreach (var monster in monsters)
            {
                output.Add($"{ monster.TimeStamp }, { monster.Researcher }, { monster.MonsterName }, { monster.Latitude }, { monster.Longitude }");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries have been written");

            Console.ReadLine();

        }


    }
}
