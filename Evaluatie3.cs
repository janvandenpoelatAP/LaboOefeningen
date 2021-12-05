using System;
namespace LaboOefeningen
{
    public class Evaluatie3
    {
        public static void AanbevolenHuisdier() 
        {
            int scoreHond = 0;
            int scoreKat = 0;
            int scoreVis = 0;

            Console.WriteLine("Ga je vaak op reis?");
            string antwoord1 = Console.ReadLine();
            Console.WriteLine("Heb je graag veel interactie met je huisdier?");
            string antwoord2 = Console.ReadLine();
            Console.WriteLine("Hecht je veel belang aan een propere vloer?");
            string antwoord3 = Console.ReadLine();

            if (antwoord1 == "ja")
            {
                scoreHond--;
            }
            if (antwoord2 == "ja")
            {
                scoreHond++; // scoreHond = scoreHond + 1;
                scoreVis--;
            }
            else if (antwoord2 == "een beetje")
            {
                scoreKat++;
                scoreVis--;
            }
            else
            {
                scoreHond--;
                scoreVis++;
            }
            if (antwoord3 == "ja")
            {
                scoreHond--;
                scoreKat--;
            }
            else if (antwoord3 == "een beetje")
            {
                scoreHond--;
            }
            else
            {
            }
            Console.WriteLine("De scores zijn:");
            Console.WriteLine($"Hond: {scoreHond}");
            Console.WriteLine($"Kat: {scoreKat}");
            Console.WriteLine($"Vis: {scoreVis}");
        }
        public static void HalloweenBegroeter()
        {
            int huidigSnoep = 0;
            string verkleedAls = "";

            int aantalChocolade = 0; // Chocolade = 0
            int aantalDrop = 0; // Drop = 1
            int aantalZuurtjes = 0; // Zuurtjes = 2

            do
            {
                Console.WriteLine("Hallo, als wat ben je verkleed?");
                verkleedAls = Console.ReadLine();

                if (!verkleedAls.Equals("niemand"))
                {
                    string snoepSelectie = "";

                    switch (huidigSnoep)
                    {
                        case 0:
                            snoepSelectie = "chocolade";
                            aantalChocolade++;
                            break;
                        case 1:
                            snoepSelectie = "drop";
                            aantalDrop++;
                            break;
                        case 2:
                            snoepSelectie = "zuurtjes";
                            aantalZuurtjes++;
                            break;
                    }

                    Console.WriteLine($"Dag {verkleedAls}, jij mag {snoepSelectie} nemen");
                    huidigSnoep++;

                    if (huidigSnoep > 2)
                    {
                        huidigSnoep = 0;
                    }
                }
            } while (!verkleedAls.Equals("niemand"));

            Console.WriteLine($"Programma wordt nu afgesloten. Er is {aantalChocolade} keer chocolade uitgedeeld, {aantalDrop} keer drop, {aantalZuurtjes} keer zuurtjes");
        }
    }
}