using System;
using System.Threading;

namespace LaboOefeningen
{
    public class Hoofdstuk08
    {
        public static void Keuzemenu() 
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Toonladder");
            Console.WriteLine("2. Chronometer");
            Console.WriteLine("3. Cirkels");
            Console.WriteLine("4. Lengte Oppervlakte Volume");
            Console.WriteLine("5. R-Waarde");
            Console.WriteLine("6. Schaar, Steen, Papier");
            Console.WriteLine("7. TextCell met Random");
            Console.WriteLine("8. TextCell met Kommagetallen");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1) 
            {
                ToonLadder();
            }
            if (keuze == 2) 
            {
                Chronometer();
            }
            if (keuze == 3) 
            {
                Cirkels();
            }
            if (keuze == 4) 
            {
                LengteOppervlakteVolume();
            }
            if (keuze == 5) 
            {
                RWaarde();
            }
            if (keuze == 6) 
            {
                SchaarSteenPapier();
            }
            if (keuze == 7) 
            {
                TextCellMetRandom.TextCellMetRandomMain();
            }
            if (keuze == 8) 
            {
                TextCellMetKomma.TextCellMetKommaMain();
            }
        }

        public static void ToonLadder()
        {
            string[] noten = { "do", "re", "mi", "fa", "sol", "la", "si" }; 
            Random random = new Random();
            int nootIndex = random.Next(7);
            Console.WriteLine($"Je willekeurige noot is {noten[nootIndex]}. Hoe veel trappen wil je stijgen?");
            int aantalTrappen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Je komt uit op {noten[(nootIndex + aantalTrappen) % noten.Length]}");
        }
        public static void Chronometer()
        {
            int aantalHondersteSeconden = 0;
            while (true)
            {
                Thread.Sleep(10);
                Console.Clear();
                aantalHondersteSeconden++;
                Console.WriteLine($":{(aantalHondersteSeconden / 100) % 60:d2}:{aantalHondersteSeconden % 100:d2}");
            }
        }
        public static void Cirkels()
        {
            Console.WriteLine("Geef de straal: ");
            double straal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De omtrek van de cirkel met straal {straal:F2} is {(straal * 2.0 * Math.PI):F2}");
            Console.WriteLine($"De oppervlakte van de cirkel met straal {straal:F2} is {(Math.Pow(straal, 2.0) * Math.PI):F2}");
        }
        public static void LengteOppervlakteVolume()
        {
            Console.Write("Hoe lang is de zijde in meter? ");
            double zijde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De lengte is {zijde} m");
            Console.WriteLine($"De oppervlake is {Math.Pow(zijde, 2)} m²");
            Console.WriteLine($"Het volume is {Math.Pow(zijde, 3)} m³");
        }
        public static void RWaarde()
        {
            Console.WriteLine("Wat is de R-waarde?");
            double rWaarde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel generaties kijken we vooruit?");
            int aantalGeneraties = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ben je O ptimistisch, N eutraal of P essimistisch?");
            string OpNePe = Console.ReadLine();

            Console.WriteLine("Het aantal besmettingen per generatie is:");
            for (int i = 0; i < aantalGeneraties; i++)
            {
                if (OpNePe == "O")
                {
                    Console.WriteLine($"Generatie {i + 1}: {Math.Floor(Math.Pow(rWaarde, i)):F0}");
                }
                else if (OpNePe == "P")
                {
                    Console.WriteLine($"Generatie {i + 1}: {Math.Ceiling(Math.Pow(rWaarde, i)):F0}");
                }
                else
                {
                    Console.WriteLine($"Generatie {i + 1}: {Math.Round(Math.Pow(rWaarde, i)):F0}");
                }
            }
        }

        public static void SchaarSteenPapier()
        {
            int scoreSpeler = 0;
            int scoreComputer = 0;
            int keuzeSpeler = 0;
            int keuzeComputer = 0;
            Random random = new Random();
            while (scoreSpeler < 10 && scoreComputer < 10)
            {
                Console.WriteLine("Maak een keuze");
                Console.WriteLine(" 1 voor schaar");
                Console.WriteLine(" 2 voor steen");
                Console.WriteLine(" 3 voor papier");
                keuzeSpeler = Convert.ToInt32(Console.ReadLine());
                keuzeComputer = random.Next(1, 4);
                if (keuzeComputer == 1)
                {
                    Console.WriteLine("De computer kiest schaar!");
                    if (keuzeSpeler == 1)
                    {
                        Console.WriteLine("Niemand wint deze ronde!");
                    }
                    else if (keuzeSpeler == 2)
                    {
                        Console.WriteLine("Jij wint deze ronde!");
                        scoreSpeler++;
                    }
                    else
                    {
                        Console.WriteLine("De computer wint deze ronde!");
                        scoreComputer++;
                    }
                }
                else if (keuzeComputer == 2)
                {
                    Console.WriteLine("De computer kiest steen!");
                    if (keuzeSpeler == 1)
                    {
                        Console.WriteLine("Jij wint deze ronde!");
                        scoreSpeler++;
                    }
                    else if (keuzeSpeler == 2)
                    {
                        Console.WriteLine("Niemand wint deze ronde!");
                    }
                    else
                    {
                        Console.WriteLine("De computer wint deze ronde!");
                        scoreComputer++;
                    }
                }
                else
                {
                    Console.WriteLine("De computer kiest papier!");
                    if (keuzeSpeler == 1)
                    {
                        Console.WriteLine("Jij wint deze ronde!");
                        scoreSpeler++;
                    }
                    else if (keuzeSpeler == 2)
                    {
                        Console.WriteLine("De computer wint deze ronde!");
                        scoreComputer++;
                    }
                    else
                    {
                        Console.WriteLine("Niemand wint deze ronde!");
                    }
                }
                Console.WriteLine($"Jij hebt {Score(scoreSpeler)}, de computer heeft {Score(scoreComputer)}.");
            }
        }
        public static string Score(int aantalPunten)
        {
            if (aantalPunten == 1)
            {
                return $"{aantalPunten} punt";
            }
            else
            {
                return $"{aantalPunten} punten";
            }
        }
    }
}
