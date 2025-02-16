using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TempleEscape
{
    internal class AnnettesRum
    {
        public void SøjleRummet()
        {
            //Intro
            string introTekst = "Du går langsomt ind i rummet. \nPludselig tændes der 4 fakler på væggene, og du lægger mærke til en mærkelig høj midt i rummet." + "\nPå højen er der en stor sten, hvor du kan se en inskription.";
            TypewriterEffect(introTekst);
            Console.Write("\n\n(Tryk for at fortsætte)");
            Console.ReadLine();


            //Gåden
            string[] boxedText =
            {
                "Fire vogtere står i ring, hver med et tal, en skjult mening bring.",
                "Den første tænder gnisten, den næste fordobler dens kraft.",
                "Den største går sidst, den mindste går først.",
                "Vælg med omhu, tryk ej forkert, for fejl kan få mørket til at vågne"
            };
            Console.WriteLine("");
            PrintBoxedTekst(boxedText);
            Console.Write("\n\n(Tryk for at fortsætte)");
            Console.ReadLine();
            
            //De fire søjler
            string kiggeRundt = "\nDu ser dig omkring i rummet.\nDer er nøjagtig 4 søjler. Ét i hvert hjørne i rummet. \nDu ser nærmere på søjlerne.\n";
            TypewriterEffect(kiggeRundt);
            string tabel = String.Format("\n║{0, -7}║{1, -7}║{2, -7}║{3, -7}║", "4", "8", "2", "16");
            string tabel1 = String.Format("║{0, -7}║{1, -7}║{2, -7}║{3, -7}║", "je", "rn", "st", "er");
            Console.WriteLine(tabel);
            Console.WriteLine(tabel1);
            Console.Write("\n\n(Tryk for at fortsætte)");
            Console.ReadLine();

            //indtastning af svar
            string introValg = "\n\nPå den store sten finder du også 4 knapper. Hver knap har et tal: 4, 8, 2 og 16. \nDu tror, du har regnet gåden ud og trykker på knapperne.";
            TypewriterEffect(introValg);

            const string korrektSvar = "24816";
            string brugerInput = "";
            int fejlTæller = 0;
            int maksForsøg = 4;
            bool erLøst = false;

            while(fejlTæller<maksForsøg)
            {
                Console.Write("\nDin rækkefølge: ");
                brugerInput=Console.ReadLine();

                if (brugerInput ==korrektSvar)
                {
                    erLøst = true;
                    break; //Løkken afsluttes, da bruger har svaret korrekt
                }
                else
                {
                    fejlTæller++;
                    string fejlMelding = "\nEn fakkel går ud, og rummet bliver mørkere...";
                    TypewriterEffect(fejlMelding);

                    if (fejlTæller<maksForsøg)
                    {
                        Console.WriteLine($"\nForsøg tilbage: {maksForsøg-fejlTæller}");
                        Console.WriteLine("Prøv igen.");
                    }
                }
            }

            //Efter løkken: Hvis gåden er løst åbnes døren, ellers game over
            if (erLøst)
            {
                string succesTekst = "\nDu hører en høj, rumlende lyd og kan se muren foran dig glide til side. \nDu tøver lidt, men går så med faste skridt gennem hullet i muren.";
                TypewriterEffect(succesTekst);
            }
            else
            {
                string gameOver = "\n\nRummet er fuldstændig mørkt... Du hører noget bevæge sig i skyggerne. \nPludselig mærker du kulden omslutte dig... Alt bliver sort. \nGame Over";
                TypewriterEffect(gameOver);
            }

            Console.ReadLine();

        }
        public void TypewriterEffect(string tekst, int delay = 50)
        {
            foreach (char c in tekst)
            {
                Console.Write(c);
                Thread.Sleep(delay); //Pause mellem hvert bogstav på 50ms
            }
        }
        public void PrintBoxedTekst(string[] boxedText) //Boks til inskriptionen 
        {
            int maxLength = 0;

            //Find den længste linje for at tilpasse bredden
            foreach (string line in boxedText)
            {
                if (line.Length > maxLength)
                    maxLength = line.Length;
            }

            string topBorder = "╔" + new string('═', maxLength + 2) + "╗";
            string bottomBorder = "╚" + new string('═', maxLength + 2) + "╝";

            Console.WriteLine(topBorder);
            foreach (string line in boxedText)
            {
                Console.WriteLine($"║ {line.PadRight(maxLength)} ║");
            }
            Console.WriteLine(bottomBorder);
        }
    }
}
