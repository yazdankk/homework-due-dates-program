using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework_due_dates_program
{
    internal class Program
    {
        private static string[] options = {"", " View Homework", " Add Homework", " Complete Homework", " Quit Program"};
        static void Main()
        {
            StreamReader fileReader = new StreamReader("homework.txt");
            Console.WriteLine("Welcome to your Homework Homescreen, Select an option");
            for (int i = 1; i < options.Length; i++)
            {
                Console.WriteLine(i + options[i]);
            }
            string userOption = Console.ReadLine();
            while (!fileReader.EndOfStream)
            {
                string line = fileReader.ReadLine();
                string[] stringsplit = line.Split(',');
                if (userOption == "1")
                {
                    string homework = stringsplit[0] + "\n" + stringsplit[1] + "\n" + stringsplit[2] + "\n" + stringsplit[3] + "\n" + stringsplit [4];
                    Console.WriteLine(homework);
                }
            }
        }
    }
}

