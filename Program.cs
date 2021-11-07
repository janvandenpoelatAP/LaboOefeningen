using System;

namespace LaboOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welk onderwerp kies je?");
            Console.WriteLine("1. Werken met Visual Studio Code");
            Console.WriteLine("2. Variabelen en datatypes");
            Console.WriteLine("3. Strings en hun methoden");
            Console.WriteLine("4. Beslissingen");
            Console.WriteLine("5. Loops");
            Console.WriteLine("6. Arrays");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                Hoofdstuk01.Keuzemenu();
            }
            else if (keuze == 2) 
            {
                Hoofdstuk02.Keuzemenu();
            }
            else if (keuze == 3) 
            {
                Hoofdstuk03.Keuzemenu();
            }
            else if (keuze == 4)
            {
                Hoofdstuk04.Keuzemenu();
            }
            else if (keuze == 5)
            {
                Hoofdstuk05.Keuzemenu();
            }
            else if (keuze == 6)
            {
                Hoofdstuk06.Keuzemenu();
            }
            // zelf aanvullen met resterende keuzemenu's voor andere onderwerpen
        }
    }
}
