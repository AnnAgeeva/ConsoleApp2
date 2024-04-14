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
            string fullName = "Анна Агеева";
            byte age = 36;
            string email = "anka-287@rambler.ru";
            double programscore = 98.2;
            double mathcsore = 80;
            double phisicscore = 78.6;
                    
          
            string newPattern = "ФИО: {0} \nВозраст: {1} \nПочта: {2} \nБалл по программированию: {3} \nБалл по математике: {4} \nБалл по физике: {5}";
            Console.WriteLine(newPattern,
                fullName,
                age,
                email,
                programscore,
                mathcsore,
                phisicscore);

            double summ = programscore + mathcsore + phisicscore;
            double average = summ / 3;
            Console.WriteLine("\nСредний балл: " + average);
            Console.ReadLine();

        }
    }
}
