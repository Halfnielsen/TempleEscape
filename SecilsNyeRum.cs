using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecilsRum
{
    internal class SecilsRum
    {
        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(30);
            }
        }

        static void Typeimage(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                double indexAsDouble = (double)i;
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(1);
            }
        }

        static void Main(string[] args)
        {

        //Introduktion 

        Introduktion:
            Thread.Sleep(250);
            Typewrite("Du vakler videre, og falder næsten over en l∅s flise.");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Rummet foran dig lugter lidt af saltvand, og her f∅les");
            Thread.Sleep(500);
            Typewrite(".");
            Thread.Sleep(500);
            Typewrite(".");
            Thread.Sleep(500);
            Typewrite(".");
            Thread.Sleep(1000);
            Typewrite(" varmt?");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Typewrite(" og er det et palmetræ foran dig?");
            Thread.Sleep(250);
            Console.Write("\n\n\n");
            Typeimage("        __ _.--..--._ _\r\n     .-' _/   _/\\_   \\_'-.\r\n    |__ /   _/\\__/\\_   \\__|\r\n       |___/\\_\\__/  \\___|\r\n              \\__/\r\n              \\__/\r\n               \\__/\r\n                \\__/\r\n             ____\\__/___");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();
            Console.Clear();



            //Kokosnød

            Thread.Sleep(250);
            Typewrite("Du ser en vej rundt om palmetræet, og f∅lger den snoede sti.");
            Thread.Sleep(250);
            Console.Write("\n\n\n");
            Console.Write("               _...\r\n            .;;'  /     /.\r\n          .;;: _   \\    \\ '.\r\n         /;;:'(_)  /    /   \\\r\n        |;;:'_    _\\    \\    |\r\n        |;;:(_)  (_)|   /    |\r\n        |;;::.     /  _/     ;\r\n         \\;;::.    / /      /   \r\n          ';;::.   \\|    _.'    _.-.   _\r\n            '-;;:. /  .-'      /_./ _  \\|\r\n                '''''              '-'");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Som du går udenom palmetræet, falder en kokosn∅d ned i hovedet på dig.");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();
            Console.Clear();



            //Kokosnød quiz

            Thread.Sleep(250);
            Typewrite("Dit kranium er så tykt, at kokosn∅dden knækker midt over og åbenbarer et æonisk sp∅rgsmål:");
            Thread.Sleep(2000);
            Console.Write("\n\n");
            Typewrite("Hvad er den bedste metode til at åbne en kokosn∅d?");
            Thread.Sleep(2000);
            Console.Write("\n\n\n");
            Typewrite("1. En hammer");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("2. En sten");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("3. En hammer");
            Thread.Sleep(500);
            Typewrite(" OG");
            Thread.Sleep(250);
            Typewrite(" en sten");
            Thread.Sleep(3000);
            Console.Write("\n\n");
            Typewrite("4.");
            Thread.Sleep(2000);
            Typeimage(" ET KÆMPESTORT, EKSTREMT, KOLOSSALT, GIGANORMT, TITANISK, MASTODONT, MAKROSKOPISK, ASTRONOMISK, ENORMT, KOSMISK, \n   KATASTROFALT, OLYMPISK, JURASSISK, OVERDIMENSIONERET, GARGANTUANSK, EKSPONENTIELT, GIGANTISK, MEGASTRUKTURELT, \n   PLANETARISK, IMPERIALT, HYPERBOLSK, ALTOPSLUGENDE, GRANDIOST, OVERPROPORTIONERET, TITANFORMET, SKYKNUSENDE, \n   VERDENSOMSPÆNDENDE, MEGALOMANT, MONSTERST0RRELSE, OVERVÆLDENDE, GRÆNSEL0ST, EVIGT VOKSENDE, OVERMENNESKELIGT, \n   TEMPELSTORT, MAMMUTRELATERET, BANEBRYDENDE, BOBBELHOVEDLIGNENDE, UHYRLIGT, MASSIVT, KONTINENTALT, VERDENSTUNGT, \n   HIMMELEKSPANDERENDE, EXOPLANETARISK, STRATOSFÆRISK, OMEGADIMENSIONELT, TIDSRUMSFORVRIDENDE, JORDSKÆLVENDE, \n   MONSTR0ST, VANDMELONFORMET, LEVIATHAN-AGTIGT MEGAKRANIUM!!!");
            Thread.Sleep(2000);
            Typeimage("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Thread.Sleep(2000);
            Console.Write("\n\n\n");
            Typewrite("Dine svarmuligheder er: ");
            Thread.Sleep(1500);
            Console.Write("[1]");
            Thread.Sleep(1500);
            Console.Write(" [2]");
            Thread.Sleep(1500);
            Console.Write(" [3]");
            Thread.Sleep(1500);
            Typewrite(" eller ");
            Thread.Sleep(500);
            Console.Write("[4].");
            Thread.Sleep(2000);



        //Kokosnød quiz svar

        SvarKokosnød:
            Console.Write("\n\n\n");
            Typewrite("> Indtast venligst dit svar her: ");
            string KokosnødSvar = Console.ReadLine();
            if (KokosnødSvar == "1")
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Du kan f∅le kokosn∅ddens vrede, og ved at den fisker efter et andet svar.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarKokosnød;
            }
            if (KokosnødSvar == "2")
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Lidt primitivt.");
                Thread.Sleep(500);
                Typewrite(" Kokosn∅dden er ikke glad for dit svar.");
                Thread.Sleep(500);
                Typewrite(" Brug dit...");
                Thread.Sleep(1000);
                Typewrite(" hoved.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarKokosnød;
            }
            if (KokosnødSvar == "3")
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Fornuftigt!");
                Thread.Sleep(1500);
                Typewrite(" Det kan kokosn∅dden ikke lide.");
                Thread.Sleep(500);
                Typewrite(" Over");
                Typewrite("hoved");
                Typewrite("et ikke.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarKokosnød;
            }
            if (KokosnødSvar == "4")
            {
                Thread.Sleep(2000);
                Console.Write("\n\n");
                Typewrite("Det er godt at du selv ved det.");
                Thread.Sleep(500);
                Typewrite(" Den knækkede kokosn∅d triller langsomt væk, og smuldrer til sand.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Du kigger ned.");
                Thread.Sleep(500);
                Typewrite(" Der er sand overalt.");
                Thread.Sleep(500);
                Typewrite(" Var det her ikke et tempel?");
                Thread.Sleep(500);
                Console.Write("\n\n\n");
                Typeimage("> Tryk 'Enter' for at fortsætte . . .");
                Console.ReadLine();
                goto SvarKokosnødKorrekt;
            }
            switch (KokosnødSvar)
            {
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    Thread.Sleep(3000);
                    Console.Write("\n\n");
                    Typewrite("Hvor mange svarmuligheder gav kokosn∅dden dig?");
                    Thread.Sleep(500);
                    Typewrite(" Har dit kæmpe hoved skabt flere svar?");
                    Thread.Sleep(1500);
                    Console.Write("\n\n");
                    goto SvarKokosnød;

                default:

                    Thread.Sleep(1500);
                    Console.Write("\n\n");
                    Typewrite("Kokosn∅dden forstod ikke dit svar.");
                    Thread.Sleep(500);
                    Typewrite(" Kun numeriske tal fra [1] til [4], tak.");
                    Thread.Sleep(1500);
                    Console.Write("\n\n");
                    goto SvarKokosnød;
            }



        //Kokosnød korrekt svar

        SvarKokosnødKorrekt:
            Console.Clear();
            Thread.Sleep(250);
            Typewrite("Du ser noget, der glimter i kokosn∅ddens sand-efterladenskaber.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typewrite("Vil du samle det op?");
            Thread.Sleep(1500);
            Console.Write(" [");
            Thread.Sleep(250);
            Typewrite("JA");
            Thread.Sleep(250);
            Console.Write(" / ");
            Thread.Sleep(250);
            Typewrite("NEJ");
            Thread.Sleep(250);
            Console.Write("]");
            Thread.Sleep(1500);





        //Nøgle

        SvarNøgle:
            Console.Write("\n\n\n");
            Typewrite("> Indtast venligst dit svar her: ");
            string NøgleSvar = Console.ReadLine();
            if (NøgleSvar.Equals("JA", StringComparison.OrdinalIgnoreCase))
            {
                goto SvarNøgleKorrekt;
            }
            if (NøgleSvar.Equals("NEJ", StringComparison.OrdinalIgnoreCase))
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Hvad er dit problem?");
                Thread.Sleep(500);
                Typewrite(" Hvem kan ikke lide skinnende ting?");
                Thread.Sleep(500);
                Typewrite(" Saml den op, ballonhoved.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarNøgle;
            }





        //Nøgle korrekt svar

        SvarNøgleKorrekt:
            Console.Clear();
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Hold da op!");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("  ¤                     |\r\n                      - ¤ -                      ¤\r\n        _   _           |         _____\r\n       | | | |                 ¤'       '.\r\n       | |_| |_¤______________/.    ^  ¤  \\ \r\n      (;;::.  ________________;:. <   >    |   _|_\r\n       '¤::.-'          ¤     \\;:.  v     /     |\r\n                               '.;_____ .'\r\n        _|_\r\n         |                                          ¤\r\n                                 |\r\n     ¤                         - ¤ -\r\n                                 |");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Du har fundet en n∅gle!");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();
            Console.Clear();





            //Mere sand

            Thread.Sleep(250);
            Typewrite("Du stikker n∅glen ned i din lomme og trasker videre gennem sandet.");
            Thread.Sleep(1000);
            Console.Write("\n\n\n\n\n");
            Typewrite("        Skridt... ");
            Thread.Sleep(1250);
            Console.Write("\n\n\n\n\n");
            Typewrite("                                                                   For skridt... ");
            Thread.Sleep(2500);
            Console.Write("\n\n\n\n\n");
            Typewrite("                           For skridt... ");
            Thread.Sleep(2000);
            Console.Write("\n\n\n\n\n");
            Typewrite("Heeeelt derude, som en oase...");
            Thread.Sleep(1000);
            Typewrite(" hvis du nu kniber ∅jnene sammen...");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at knibe ∅jnene sammen . . .");
            Console.ReadLine();
            Console.Clear();



            //Sol

            Console.Write("                         ¤\r\n                         \r\n                         ¤             \r\n      ¤                                    ¤\r\n                         ¤        \r\n          ¤              ¤             ¤\r\n            ¤                        ¤\r\n              ¤     . ¤ '¤' ¤ .    ¤ \r\n                 .¤'           '¤. \r\n                .¤               ¤.\r\n                ¤.               .¤\r\n ¤    ¤  ¤  ¤  :¤:.             .:¤:  ¤  ¤  ¤    ¤   \r\n                ¤;:.           .:;¤  \r\n                '¤;::.       .::;¤'   \r\n                  '¤;::::::::::;¤'  \r\n              ¤     ''¤':¤:'¤''    ¤\r\n            ¤                        ¤\r\n          ¤              ¤             ¤\r\n                         ¤          \r\n      ¤                                    ¤\r\n                         ¤         \r\n                         \r\n                         ¤  ");
            Thread.Sleep(2000);
            Console.Write("\n                                                     ");
            Typewrite("Solen skinner!");
            Thread.Sleep(2000);
            Typewrite(" Men du skal kigge altså lidt længere ned.");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at kigge længere ned . . .");
            Console.ReadLine();
            Console.Clear();



            //Døren 

            Console.Write("\r\n       __       _ __                                               \r\n                          ______________________\r\n         __|___    __   //  __________________  \\        _    \r\n                       //  /   |          |  \\\\  \\\r\n    _ |____ __ _|__   //  /    |          |   \\\\  \\  _| _______ |___  ___ \r\n           |         //  /     |          |    \\\\  \\       |\r\n   ___ ____|_ ____  //  /      |          |     \\\\  \\   __ | _____ _ |_   \r\n      |            //  /       |          |      \\\\  \\          |\r\n    __|___  ____  //  /________|__________|_______\\\\  \\ ___ ___ |___  ____\r\n           |      ||  |___________________________||  |    |         |\r\n_ ____ ____|_____ ||  |        |          |       ||  | ___|_________|___   _\r\n      |           ||  |        |          |  ___  ||  |         |         |\r\n  ____|____ ___ _ ||  |        |          | ||_|| ||  | ___ __  |_ __   _                              \r\n |         |      ||  |        |          |[_ § _]||  |    |         |\r\n   _______ |_____ ||  |        |          |[_____]||  | __ | _____ _ |____\r\n      |           ||  |________|__________|_______||  |         |         \r\n   __ | ___ __  _ ||  |___________________________||  |  __ ___ |___  ___\r\n           |      ||  |        |          |       ||  |    |         |\r\n  ____  ___|____  ||  |        |          |       ||  | _ _.- .__  _.-.\r\n      |           ||  |        |          |       ||  |.-'      ' -''\r\n     _|___  _.-'      '-._     |          |       ||_/   .      :'   \r\n      '-.__.-'  .  .:: .  '. _ |          |_ .--' .     '.     '\r\n             .   '           . ':'- . _.-':' ' .:'  .");
            Thread.Sleep(3000);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at unders∅ge den mystiske d∅r . . .");
            Console.ReadLine();
            Console.Clear();



            //Låsen

            Console.Write("\r\n                              ___                   .\r\n                             |   |                   \r\n                             |   |                  .\r\n                             |   |                   \r\n                   __________|   |__________        .\r\n                 /           |   |           \\      .\r\n                /    ________|   |________    \\     .\r\n               /    /        |___|        \\    \\    .\r\n               |    |                     |    |    .\r\n               |    |                     |    |    .\r\n    .   . . . .|    | . . . . . . . . . . |    |. . \r\n               |    |                     |    |\r\n             __|____|_____________________|____|__\r\n           /  __                               __  \\\r\n          /  /  \\                             /  \\  \\\r\n          |  \\__/            _____            \\__/  |\r\n          |                /       \\                |\r\n          |               |         |               |\r\n          |                \\       /                |\r\n           \\ ______________/       \\______________ /\r\n           /              /         \\              \\\r\n          |              /___________\\              |\r\n          |                                         |\r\n          |                                         |\r\n          |                                         |\r\n           \\_______________________________________/\r\n");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typewrite("Perfekt! N∅glen må passe herind.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typeimage("> Tryk 'Enter' for at låse d∅ren op . . .");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.Write("\n");
            Typewrite("...");
            Console.Write("\n\n");
            Thread.Sleep(1000);
            Typewrite("N∅glen knækker midt over, og dit hårde arbejde er gået til spilde.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typewrite("Du slår på låsen ud af frustration, og du ser en kryptisk kode bagpå.");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typeimage("> Tryk 'Enter' for at unders∅ge koden . . .");
            Console.ReadLine();
            Console.Clear();

            //Kryptisk kode

            Console.Write("\r\n                              ___                   .\r\n                             |   |                   \r\n                             |   |                  .\r\n                             |   |                   \r\n                   __________|   |__________        .\r\n                 /           |   |           \\      .\r\n                /    ________|   |________    \\     .\r\n               /    /        |___|        \\    \\    .\r\n               |    |                     |    |    .\r\n               |    |                     |    |    .\r\n    .   . . . .|    | . . . . . . . . . . |    |. .\r\n               |    |                     |    |\r\n             __|____|_____________________|____|__\r\n           /                                       \\\r\n          /                                         \\\r\n          |                            P            |\r\n          |                                         |\r\n          |      A                              M   |\r\n          |                     E                   |\r\n          |                                         |\r\n          |            T             Æ              |\r\n          |                                         |\r\n          |   L                                     |\r\n          |                       R                 |\r\n          |                                         |\r\n           \\_______________________________________/");
            Thread.Sleep(1500);
            Console.Write("\n\n\n");
            Typewrite("Den her super-krypterede kode virker bekendt - det ligner et anagram?");
            Thread.Sleep(500);

            //Kodeord 
            Console.Write("\n\n\n");
            Typewrite("Byt rundt på bogstaverne for at finde det korrekte kodeord.");

        Kodeord:
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Indtast kodeord her: ");
            string Kodeord = Console.ReadLine();
            if (Kodeord.Equals("PALMETRÆ", StringComparison.OrdinalIgnoreCase))
            {
                goto Afslutning;
            }
            else
            {
                Thread.Sleep(1500);
                Typewrite("Tæt på! Koden rimer på 'SALMEKRÆ'.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto Kodeord;
            }

        Afslutning:
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Korrekt! Men hvad nu?");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Du står og tænker i næsten et helt sekund, f∅r en ny kokosn∅d falder ud af et palmetræ.");
            Thread.Sleep(500);
            Console.Write("\n");
            Typewrite("Kokosn∅dden rammer og ∅delægger låsen på d∅ren - den er i sidste ende din bedste ven.");
            Thread.Sleep(500);
            Console.Write("\n");
            Typewrite("Frihed er i dine hænder nu.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typewrite("Vil du forlade rummet?");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typeimage("> Tast [JA] for at forlade rummet, eller [NEJ] for at starte rummet forfra: ");
            string Beslutning = Console.ReadLine();
            if (Beslutning.Equals("JA", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                goto TheEnd;
            }
            if (Beslutning.Equals("NEJ", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                goto Introduktion;
            }

        TheEnd:
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Du tager i håndtaget og forlader rummet.");
            Thread.Sleep(1500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();

        }
    }
}
namespace SecilsRum
{
    internal class SecilsRum
    {
        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(30);
            }
        }

        static void Typeimage(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                double indexAsDouble = (double)i;
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(1);
            }
        }

        static void Main(string[] args)
        {

        //Introduktion 

        Introduktion:
            Thread.Sleep(250);
            Typewrite("Du vakler videre, og falder næsten over en l∅s flise.");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Rummet foran dig lugter lidt af saltvand, og her f∅les");
            Thread.Sleep(500);
            Typewrite(".");
            Thread.Sleep(500);
            Typewrite(".");
            Thread.Sleep(500);
            Typewrite(".");
            Thread.Sleep(1000);
            Typewrite(" varmt?");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Typewrite(" og er det et palmetræ foran dig?");
            Thread.Sleep(250);
            Console.Write("\n\n\n");
            Typeimage("        __ _.--..--._ _\r\n     .-' _/   _/\\_   \\_'-.\r\n    |__ /   _/\\__/\\_   \\__|\r\n       |___/\\_\\__/  \\___|\r\n              \\__/\r\n              \\__/\r\n               \\__/\r\n                \\__/\r\n             ____\\__/___");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();
            Console.Clear();



            //Kokosnød

            Thread.Sleep(250);
            Typewrite("Du ser en vej rundt om palmetræet, og f∅lger den snoede sti.");
            Thread.Sleep(250);
            Console.Write("\n\n\n");
            Console.Write("               _...\r\n            .;;'  /     /.\r\n          .;;: _   \\    \\ '.\r\n         /;;:'(_)  /    /   \\\r\n        |;;:'_    _\\    \\    |\r\n        |;;:(_)  (_)|   /    |\r\n        |;;::.     /  _/     ;\r\n         \\;;::.    / /      /   \r\n          ';;::.   \\|    _.'    _.-.   _\r\n            '-;;:. /  .-'      /_./ _  \\|\r\n                '''''              '-'");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Som du går udenom palmetræet, falder en kokosn∅d ned i hovedet på dig.");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();
            Console.Clear();



            //Kokosnød quiz

            Thread.Sleep(250);
            Typewrite("Dit kranium er så tykt, at kokosn∅dden knækker midt over og åbenbarer et æonisk sp∅rgsmål:");
            Thread.Sleep(2000);
            Console.Write("\n\n");
            Typewrite("Hvad er den bedste metode til at åbne en kokosn∅d?");
            Thread.Sleep(2000);
            Console.Write("\n\n\n");
            Typewrite("1. En hammer");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("2. En sten");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("3. En hammer");
            Thread.Sleep(500);
            Typewrite(" OG");
            Thread.Sleep(250);
            Typewrite(" en sten");
            Thread.Sleep(3000);
            Console.Write("\n\n");
            Typewrite("4.");
            Thread.Sleep(2000);
            Typeimage(" ET KÆMPESTORT, EKSTREMT, KOLOSSALT, GIGANORMT, TITANISK, MASTODONT, MAKROSKOPISK, ASTRONOMISK, ENORMT, KOSMISK, \n   KATASTROFALT, OLYMPISK, JURASSISK, OVERDIMENSIONERET, GARGANTUANSK, EKSPONENTIELT, GIGANTISK, MEGASTRUKTURELT, \n   PLANETARISK, IMPERIALT, HYPERBOLSK, ALTOPSLUGENDE, GRANDIOST, OVERPROPORTIONERET, TITANFORMET, SKYKNUSENDE, \n   VERDENSOMSPÆNDENDE, MEGALOMANT, MONSTERST0RRELSE, OVERVÆLDENDE, GRÆNSEL0ST, EVIGT VOKSENDE, OVERMENNESKELIGT, \n   TEMPELSTORT, MAMMUTRELATERET, BANEBRYDENDE, BOBBELHOVEDLIGNENDE, UHYRLIGT, MASSIVT, KONTINENTALT, VERDENSTUNGT, \n   HIMMELEKSPANDERENDE, EXOPLANETARISK, STRATOSFÆRISK, OMEGADIMENSIONELT, TIDSRUMSFORVRIDENDE, JORDSKÆLVENDE, \n   MONSTR0ST, VANDMELONFORMET, LEVIATHAN-AGTIGT MEGAKRANIUM!!!");
            Thread.Sleep(2000);
            Typeimage("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Thread.Sleep(2000);
            Console.Write("\n\n\n");
            Typewrite("Dine svarmuligheder er: ");
            Thread.Sleep(1500);
            Console.Write("[1]");
            Thread.Sleep(1500);
            Console.Write(" [2]");
            Thread.Sleep(1500);
            Console.Write(" [3]");
            Thread.Sleep(1500);
            Typewrite(" eller ");
            Thread.Sleep(500);
            Console.Write("[4].");
            Thread.Sleep(2000);



        //Kokosnød quiz svar

        SvarKokosnød:
            Console.Write("\n\n\n");
            Typewrite("> Indtast venligst dit svar her: ");
            string KokosnødSvar = Console.ReadLine();
            if (KokosnødSvar == "1")
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Du kan f∅le kokosn∅ddens vrede, og ved at den fisker efter et andet svar.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarKokosnød;
            }
            if (KokosnødSvar == "2")
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Lidt primitivt.");
                Thread.Sleep(500);
                Typewrite(" Kokosn∅dden er ikke glad for dit svar.");
                Thread.Sleep(500);
                Typewrite(" Brug dit...");
                Thread.Sleep(1000);
                Typewrite(" hoved.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarKokosnød;
            }
            if (KokosnødSvar == "3")
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Fornuftigt!");
                Thread.Sleep(1500);
                Typewrite(" Det kan kokosn∅dden ikke lide.");
                Thread.Sleep(500);
                Typewrite(" Over");
                Typewrite("hoved");
                Typewrite("et ikke.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarKokosnød;
            }
            if (KokosnødSvar == "4")
            {
                Thread.Sleep(2000);
                Console.Write("\n\n");
                Typewrite("Det er godt at du selv ved det.");
                Thread.Sleep(500);
                Typewrite(" Den knækkede kokosn∅d triller langsomt væk, og smuldrer til sand.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Du kigger ned.");
                Thread.Sleep(500);
                Typewrite(" Der er sand overalt.");
                Thread.Sleep(500);
                Typewrite(" Var det her ikke et tempel?");
                Thread.Sleep(500);
                Console.Write("\n\n\n");
                Typeimage("> Tryk 'Enter' for at fortsætte . . .");
                Console.ReadLine();
                goto SvarKokosnødKorrekt;
            }
            switch (KokosnødSvar)
            {
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    Thread.Sleep(3000);
                    Console.Write("\n\n");
                    Typewrite("Hvor mange svarmuligheder gav kokosn∅dden dig?");
                    Thread.Sleep(500);
                    Typewrite(" Har dit kæmpe hoved skabt flere svar?");
                    Thread.Sleep(1500);
                    Console.Write("\n\n");
                    goto SvarKokosnød;

                default:

                    Thread.Sleep(1500);
                    Console.Write("\n\n");
                    Typewrite("Kokosn∅dden forstod ikke dit svar.");
                    Thread.Sleep(500);
                    Typewrite(" Kun numeriske tal fra [1] til [4], tak.");
                    Thread.Sleep(1500);
                    Console.Write("\n\n");
                    goto SvarKokosnød;
            }



        //Kokosnød korrekt svar

        SvarKokosnødKorrekt:
            Console.Clear();
            Thread.Sleep(250);
            Typewrite("Du ser noget, der glimter i kokosn∅ddens sand-efterladenskaber.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typewrite("Vil du samle det op?");
            Thread.Sleep(1500);
            Console.Write(" [");
            Thread.Sleep(250);
            Typewrite("JA");
            Thread.Sleep(250);
            Console.Write(" / ");
            Thread.Sleep(250);
            Typewrite("NEJ");
            Thread.Sleep(250);
            Console.Write("]");
            Thread.Sleep(1500);





        //Nøgle

        SvarNøgle:
            Console.Write("\n\n\n");
            Typewrite("> Indtast venligst dit svar her: ");
            string NøgleSvar = Console.ReadLine();
            if (NøgleSvar.Equals("JA", StringComparison.OrdinalIgnoreCase))
            {
                goto SvarNøgleKorrekt;
            }
            if (NøgleSvar.Equals("NEJ", StringComparison.OrdinalIgnoreCase))
            {
                Thread.Sleep(1500);
                Console.Write("\n\n");
                Typewrite("Hvad er dit problem?");
                Thread.Sleep(500);
                Typewrite(" Hvem kan ikke lide skinnende ting?");
                Thread.Sleep(500);
                Typewrite(" Saml den op, ballonhoved.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto SvarNøgle;
            }





        //Nøgle korrekt svar

        SvarNøgleKorrekt:
            Console.Clear();
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Hold da op!");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("  ¤                     |\r\n                      - ¤ -                      ¤\r\n        _   _           |         _____\r\n       | | | |                 ¤'       '.\r\n       | |_| |_¤______________/.    ^  ¤  \\ \r\n      (;;::.  ________________;:. <   >    |   _|_\r\n       '¤::.-'          ¤     \\;:.  v     /     |\r\n                               '.;_____ .'\r\n        _|_\r\n         |                                          ¤\r\n                                 |\r\n     ¤                         - ¤ -\r\n                                 |");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Du har fundet en n∅gle!");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();
            Console.Clear();





            //Mere sand

            Thread.Sleep(250);
            Typewrite("Du stikker n∅glen ned i din lomme og trasker videre gennem sandet.");
            Thread.Sleep(1000);
            Console.Write("\n\n\n\n\n");
            Typewrite("        Skridt... ");
            Thread.Sleep(1250);
            Console.Write("\n\n\n\n\n");
            Typewrite("                                                                   For skridt... ");
            Thread.Sleep(2500);
            Console.Write("\n\n\n\n\n");
            Typewrite("                           For skridt... ");
            Thread.Sleep(2000);
            Console.Write("\n\n\n\n\n");
            Typewrite("Heeeelt derude, som en oase...");
            Thread.Sleep(1000);
            Typewrite(" hvis du nu kniber ∅jnene sammen...");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at knibe ∅jnene sammen . . .");
            Console.ReadLine();
            Console.Clear();



            //Sol

            Console.Write("                         ¤\r\n                         \r\n                         ¤             \r\n      ¤                                    ¤\r\n                         ¤        \r\n          ¤              ¤             ¤\r\n            ¤                        ¤\r\n              ¤     . ¤ '¤' ¤ .    ¤ \r\n                 .¤'           '¤. \r\n                .¤               ¤.\r\n                ¤.               .¤\r\n ¤    ¤  ¤  ¤  :¤:.             .:¤:  ¤  ¤  ¤    ¤   \r\n                ¤;:.           .:;¤  \r\n                '¤;::.       .::;¤'   \r\n                  '¤;::::::::::;¤'  \r\n              ¤     ''¤':¤:'¤''    ¤\r\n            ¤                        ¤\r\n          ¤              ¤             ¤\r\n                         ¤          \r\n      ¤                                    ¤\r\n                         ¤         \r\n                         \r\n                         ¤  ");
            Thread.Sleep(2000);
            Console.Write("\n                                                     ");
            Typewrite("Solen skinner!");
            Thread.Sleep(2000);
            Typewrite(" Men du skal kigge altså lidt længere ned.");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at kigge længere ned . . .");
            Console.ReadLine();
            Console.Clear();



            //Døren 

            Console.Write("\r\n       __       _ __                                               \r\n                          ______________________\r\n         __|___    __   //  __________________  \\        _    \r\n                       //  /   |          |  \\\\  \\\r\n    _ |____ __ _|__   //  /    |          |   \\\\  \\  _| _______ |___  ___ \r\n           |         //  /     |          |    \\\\  \\       |\r\n   ___ ____|_ ____  //  /      |          |     \\\\  \\   __ | _____ _ |_   \r\n      |            //  /       |          |      \\\\  \\          |\r\n    __|___  ____  //  /________|__________|_______\\\\  \\ ___ ___ |___  ____\r\n           |      ||  |___________________________||  |    |         |\r\n_ ____ ____|_____ ||  |        |          |       ||  | ___|_________|___   _\r\n      |           ||  |        |          |  ___  ||  |         |         |\r\n  ____|____ ___ _ ||  |        |          | ||_|| ||  | ___ __  |_ __   _                              \r\n |         |      ||  |        |          |[_ § _]||  |    |         |\r\n   _______ |_____ ||  |        |          |[_____]||  | __ | _____ _ |____\r\n      |           ||  |________|__________|_______||  |         |         \r\n   __ | ___ __  _ ||  |___________________________||  |  __ ___ |___  ___\r\n           |      ||  |        |          |       ||  |    |         |\r\n  ____  ___|____  ||  |        |          |       ||  | _ _.- .__  _.-.\r\n      |           ||  |        |          |       ||  |.-'      ' -''\r\n     _|___  _.-'      '-._     |          |       ||_/   .      :'   \r\n      '-.__.-'  .  .:: .  '. _ |          |_ .--' .     '.     '\r\n             .   '           . ':'- . _.-':' ' .:'  .");
            Thread.Sleep(3000);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at unders∅ge den mystiske d∅r . . .");
            Console.ReadLine();
            Console.Clear();



            //Låsen

            Console.Write("\r\n                              ___                   .\r\n                             |   |                   \r\n                             |   |                  .\r\n                             |   |                   \r\n                   __________|   |__________        .\r\n                 /           |   |           \\      .\r\n                /    ________|   |________    \\     .\r\n               /    /        |___|        \\    \\    .\r\n               |    |                     |    |    .\r\n               |    |                     |    |    .\r\n    .   . . . .|    | . . . . . . . . . . |    |. . \r\n               |    |                     |    |\r\n             __|____|_____________________|____|__\r\n           /  __                               __  \\\r\n          /  /  \\                             /  \\  \\\r\n          |  \\__/            _____            \\__/  |\r\n          |                /       \\                |\r\n          |               |         |               |\r\n          |                \\       /                |\r\n           \\ ______________/       \\______________ /\r\n           /              /         \\              \\\r\n          |              /___________\\              |\r\n          |                                         |\r\n          |                                         |\r\n          |                                         |\r\n           \\_______________________________________/\r\n");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typewrite("Perfekt! N∅glen må passe herind.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typeimage("> Tryk 'Enter' for at låse d∅ren op . . .");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.Write("\n");
            Typewrite("...");
            Console.Write("\n\n");
            Thread.Sleep(1000);
            Typewrite("N∅glen knækker midt over, og dit hårde arbejde er gået til spilde.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typewrite("Du slår på låsen ud af frustration, og du ser en kryptisk kode bagpå.");
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typeimage("> Tryk 'Enter' for at unders∅ge koden . . .");
            Console.ReadLine();
            Console.Clear();

            //Kryptisk kode

            Console.Write("\r\n                              ___                   .\r\n                             |   |                   \r\n                             |   |                  .\r\n                             |   |                   \r\n                   __________|   |__________        .\r\n                 /           |   |           \\      .\r\n                /    ________|   |________    \\     .\r\n               /    /        |___|        \\    \\    .\r\n               |    |                     |    |    .\r\n               |    |                     |    |    .\r\n    .   . . . .|    | . . . . . . . . . . |    |. .\r\n               |    |                     |    |\r\n             __|____|_____________________|____|__\r\n           /                                       \\\r\n          /                                         \\\r\n          |                            P            |\r\n          |                                         |\r\n          |      A                              M   |\r\n          |                     E                   |\r\n          |                                         |\r\n          |            T             Æ              |\r\n          |                                         |\r\n          |   L                                     |\r\n          |                       R                 |\r\n          |                                         |\r\n           \\_______________________________________/");
            Thread.Sleep(1500);
            Console.Write("\n\n\n");
            Typewrite("Den her super-krypterede kode virker bekendt - det ligner et anagram?");
            Thread.Sleep(500);

            //Kodeord 
            Console.Write("\n\n\n");
            Typewrite("Byt rundt på bogstaverne for at finde det korrekte kodeord.");

        Kodeord:
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Indtast kodeord her: ");
            string Kodeord = Console.ReadLine();
            if (Kodeord.Equals("PALMETRÆ", StringComparison.OrdinalIgnoreCase))
            {
                goto Afslutning;
            }
            else
            {
                Thread.Sleep(1500);
                Typewrite("Tæt på! Koden rimer på 'SALMEKRÆ'.");
                Thread.Sleep(1500);
                Console.Write("\n\n");
                goto Kodeord;
            }

        Afslutning:
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Korrekt! Men hvad nu?");
            Thread.Sleep(500);
            Console.Write("\n\n\n");
            Typewrite("Du står og tænker i næsten et helt sekund, f∅r en ny kokosn∅d falder ud af et palmetræ.");
            Thread.Sleep(500);
            Console.Write("\n");
            Typewrite("Kokosn∅dden rammer og ∅delægger låsen på d∅ren - den er i sidste ende din bedste ven.");
            Thread.Sleep(500);
            Console.Write("\n");
            Typewrite("Frihed er i dine hænder nu.");
            Thread.Sleep(500);
            Console.Write("\n\n");
            Typewrite("Vil du forlade rummet?");
            Thread.Sleep(1000);
            Console.Write("\n\n\n");
            Typeimage("> Tast [JA] for at forlade rummet, eller [NEJ] for at starte rummet forfra: ");
            string Beslutning = Console.ReadLine();
            if (Beslutning.Equals("JA", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                goto TheEnd;
            }
            if (Beslutning.Equals("NEJ", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                goto Introduktion;
            }

        TheEnd:
            Thread.Sleep(1500);
            Console.Write("\n\n");
            Typewrite("Du tager i håndtaget og forlader rummet.");
            Thread.Sleep(1500);
            Console.Write("\n\n\n");
            Typeimage("> Tryk 'Enter' for at fortsætte . . .");
            Console.ReadLine();

        }
    }
}
