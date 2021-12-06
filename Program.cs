using System;

namespace LaboOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Evaluatie3.AanbevolenHuisdier();
            Console.WriteLine("Welk onderwerp kies je?");
            Console.WriteLine("1. Werken met Visual Studio Code");
            Console.WriteLine("2. Variabelen en datatypes");
            Console.WriteLine("3. Strings en hun methoden");
            Console.WriteLine("4. Beslissingen");
            Console.WriteLine("5. Loops");
            Console.WriteLine("6. Arrays");
            Console.WriteLine("7. Methoden");
            Console.WriteLine("8. Numerieke Data");
            Console.WriteLine("9. Multidimensionale arrays");
            Console.WriteLine("10. TextCell");
            Console.WriteLine("11. TextCellMetRandom");
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
            else if (keuze == 7)
            {
                Hoofdstuk07.Keuzemenu();
            }
            else if (keuze == 8)
            {
                Hoofdstuk08.Keuzemenu();
            }
            else if (keuze == 9)
            {
                Hoofdstuk09.Keuzemenu();
            }
            else if (keuze == 10)
            {
                TextCell.TextCellMain();
            }
            else if (keuze == 11)
            {
                TextCellMetRandom.TextCellMain();
            }
            // zelf aanvullen met resterende keuzemenu's voor andere onderwerpen
        }
    }
}
