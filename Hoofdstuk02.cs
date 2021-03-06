using System;
namespace LaboOefeningen
{
    public class Hoofdstuk02 
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Optellen");
            Console.WriteLine("2. VerbruikWagen");
            Console.WriteLine("3. Beetje Wiskunde");
            Console.WriteLine("4. Gemiddelde");
            Console.WriteLine("5. Maaltafels");
            Console.WriteLine("6. Ruimte");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                Optellen();
            }
            else if (keuze == 2) 
            {
                VerbruikWagen();
            }
            else if (keuze == 3) 
            {
                BeetjeWiskunde();
            }
            else if (keuze == 4) 
            {
                Gemiddelde();
            }
            else if (keuze == 5) 
            {
                Maaltafels();
            }
            else if (keuze == 6) 
            {
                Ruimte();
            }
        }
        public static void Optellen()
        {
            Console.WriteLine("Wat is het eerste getal?");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine("De som van " + getal1 + " en " + getal2 + " is " + som);
        }
        public static void VerbruikWagen()
        {
            Console.Write("Geef aantal liters voor de rit:");
            int aantalLiterinTankVoorRit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef aantal liters na de rit:");
            int aantalLiterinTankNaRit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef kilometer voor de rit:");
            int kilometerstandVoorRit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef kilometerstand na de rit:");
            int kilometerstandNaRit  = Convert.ToInt32(Console.ReadLine());
            double verbruik = (100.0 * (aantalLiterinTankVoorRit - aantalLiterinTankNaRit) / (kilometerstandNaRit - kilometerstandVoorRit));
            Console.WriteLine("Verbruik is: " + verbruik);
        }
        public static void BeetjeWiskunde()
        {
            float resultaat = -1 + 4 * 6;
            Console.WriteLine(resultaat);
            resultaat = ( 35+ 5 ) * 7;
            Console.WriteLine(resultaat);
            resultaat = 14 + -4 * 6 / 11f;
            Console.WriteLine(resultaat);
        }
        public static void Gemiddelde()
        {
            float gemiddelde = (18 + 11 + 8) / 3.0f;
            Console.WriteLine(gemiddelde);
        }
        public static void Maaltafels()
        {
            int teller = 1;
            int basisgetal = 511;
            int product = teller * basisgetal;
            Console.WriteLine(teller + " maal " + basisgetal + " is " + product);
            Console.ReadKey();
            Console.Clear();
            teller = teller + 1;
            product = teller * basisgetal;
            Console.WriteLine(teller + " maal " + basisgetal + " is " + product);
            Console.ReadKey();
            Console.Clear();
            teller = teller + 1;
            product = teller * basisgetal;
            Console.WriteLine(teller + " maal " + basisgetal + " is " + product);
        }
        public static void Ruimte() 
        {
            double gewicht = 69.0;
            Console.WriteLine("Op Mercurius voel je je alsof je " + gewicht * 0.38 + " weegt");
            Console.WriteLine("Op Venus voel je je alsof je " + gewicht * 0.91 + " weegt");
            Console.WriteLine("Op Aarde voel je je alsof je " + gewicht * 1.00 + " weegt");
            Console.WriteLine("Op Mars voel je je alsof je " + gewicht * 0.38 + " weegt");
            Console.WriteLine("Op Jupiter voel je je alsof je " + gewicht * 2.34 + " weegt");
            Console.WriteLine("Op Saturnus voel je je alsof je " + gewicht * 1.06 + " weegt");
            Console.WriteLine("Op Uranus voel je je alsof je " + gewicht * 0.92 + " weegt");
            Console.WriteLine("Op Neptunus voel je je alsof je " + gewicht * 1.19 + " weegt");
            Console.WriteLine("Op Pluto voel je je alsof je " + gewicht * 0.06 + " weegt");
        }
    }
}