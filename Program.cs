using System;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[7]
            {
                "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi", " "
            };
            int i;
            Console.WriteLine("Indice 1 : " + weekDays[1]);
            Console.WriteLine("Indice 4 : " + weekDays[4]);
            Console.WriteLine("1er Element : " + weekDays[0]);
            Console.WriteLine("4ème Element :" + weekDays[3]);
            weekDays[3] = "Jeudi";
            weekDays[6] = "Dimanche";
            for (i = 0; i<7; i++)
            {
                Console.WriteLine((i + 1) + "e jour de la semaine : " + weekDays[i]);
            }
        }
    }
}
