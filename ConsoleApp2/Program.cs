using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Anna Ageeva";
            byte age = 36;
            string email = "anka-287@rambler.ru";
            double programscore = 98.2;
            double mathcsore = 80;
            double phisicscore = 78.6;

            Console.WriteLine(fullName);
            Console.WriteLine(age);
            Console.WriteLine(email);
            Console.WriteLine(programscore);
            Console.WriteLine(mathcsore);
            Console.WriteLine(phisicscore);
            Console.ReadLine();

            double summ = programscore + mathcsore + phisicscore;
            double average = summ / 3;
            Console.WriteLine(average);
            Console.ReadLine();



        }
    }
}
