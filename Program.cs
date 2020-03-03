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

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            // Adding files to the CSV file

            lines.Add("2020-3-3 14:30:15, Heidi Smith, Cthulu, 46.057457, -120.088088");
            File.WriteAllLines(filePath, lines);
            Console.ReadLine();
        }

    }
}
