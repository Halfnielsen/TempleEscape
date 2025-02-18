using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using static System.Net.Mime.MediaTypeNames;

namespace TempleEscape
{

    class TrillionRoom //: Room
    {
        //Ny test1
        AnnettesRum nextRoom;

        private int textSpeed = 50;
        private int frustratedTextSpeed = 5;
        private int correctAnswer = 3;
        bool skip = false;


        // spiller velkomst og rum beskrivelse 
        public string roomDescription = "Velkommen fremmede! Besvar spørgsmålet!";
        // sprøgsmålet stilles
        private string question = "Hvilket land er kendt som 'The Land of the Rising Sun'?";
        private string[] options = new string[]
        {
            "1. Kina",
            "2. Indien",
            "3. Sydkorea",
            "4. Japan",
            "5. Rejs dig op fra stolen og gå over mod døren"

        };

        public string questionCorrect = "%@#!...Godt gået!";

        public void StartTirllionRoom()
        {
            RoomIntro();
        }
        public void RoomIntro()
        {
            Console.Clear();
            
            string introText = "Du befinder dig i et mørkt rum, belyst af flakkende fakler.\n\n" +
                            "Foran dig sidder en skikkelse på en trone. Silhuetten er mørk, men skærmen foran ham lyser hans ansigt op i et uhyggeligt skær.\n" +
                            "Foran ham er en stol, rettet mod skærmen. Du føler dig nærmest tvunget til at sætte dig i den... Der er dog en dør bag ham\n\n";
            ShowTextSlowly(introText);


            while (true) //Starter en løkke og breaker den med break
            {
                Console.WriteLine("Hvad vil du gøre?");
                Console.WriteLine("1: Sæt dig i stolen.");
                Console.WriteLine("2: Ignorér skikkelsen og gå mod døren bag ham.\n");

                Console.Write("Dit valg: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    string sitDownText = "\nDu sætter dig langsomt i stolen. Skærmen foran dig blinker til liv, og skikkelsen smiler skummelt...\n";
                    ShowTextSlowly(sitDownText);
                    Console.ReadLine();
                    ShowTextSlowly(roomDescription);
                    TirllionQuestion();
                    break; 
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    string ignorerHamText = "\nDu ignorerer stolen og bevæger dig mod døren. Skikkelsens blik følger dig, men han siger intet...\n";
                    ShowTextSlowly(ignorerHamText);
                    Console.ReadLine();
                    IgnorerForsæt();
                    break;  
                }
                else
                {
                    Console.WriteLine("\nDu tøver, men skikkelsen stirrer afventende på dig. Du må vælge...\n");
                }
            }
            /*
            Console.WriteLine("Med en rungende stemme taler skikkelsen:\n");

            Console.WriteLine("\n");
            */
        }
        public void IgnorerForsæt()
        {
            string tilbageigenText = ("Det nye rum åbner op og du indser....\n");
            ShowTextSlowly(tilbageigenText);
            Console.ReadLine();
            RoomIntro();
        }

        
        public void TirllionQuestion()
        {
            
            RoomQuestion(question);

            string userInput = Console.ReadLine();
            int userChoice;

            // Tjek for at se om indput ikke er int
            if (string.IsNullOrWhiteSpace(userInput) || !int.TryParse(userInput, out userChoice))
            {
                Console.Clear();
                ShowTextSlowly("\nTænk dig om! Vælg et nummer..\n");
                TirllionQuestion(); 
                return;  
            }

            
            if (userChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("\nNEJ!");
                Console.ReadLine();
                Console.Clear();
                string tryAgainText = "\nPrøv igen...\n";
                ShowTextSlowly(tryAgainText);
                TirllionQuestion();  //Sprøg igen
            }
            else if (userChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("\nHVAD MENER DU!?");
                Console.ReadLine();
                Console.Clear();
                string tryAgainText = "\nPrøv igen...\n";
                ShowTextSlowly(tryAgainText);
                TirllionQuestion();  
            }
            else if (userChoice == 3)
            {
                Console.Clear();
                Console.WriteLine("\nNÆSTEN!..");
                Console.ReadLine();
                Console.Clear();
                string tryAgainText = "\nPrøv igen...\n";
                ShowTextSlowly(tryAgainText);
                TirllionQuestion();  
            }
            else if (userChoice == 5)
            {
                Console.Clear();
                string ignorerHamText = "\nDu rejser dig fra stolen og bevæger dig mod døren. Skikkelsens blik følger dig, men han siger intet...\n";
                ShowTextSlowly(ignorerHamText);
                IgnorerForsæt();
            }
            else
            {
                Console.Clear();
                ShowTextFast(questionCorrect);
                Console.ReadLine();
                Console.Clear();
                EnterNextRoom();
            }
        }


        public void RoomQuestion(string text)
        {
            Console.WriteLine("\n" + question);

            foreach (var choice in options)
            {
                Console.WriteLine(choice);
            }
            Console.Write("\n");
        }
        //Vis tekst langsommere
        private void ShowTextSlowly(string text)
        {
            bool skip = false;
            
            //Starter en ny tråd som er en asynkron opgave der
            //Lytter efter Enter tryk
            Task.Run(() => CheckForEnter(ref skip)); 

            int startIndex = 0; // Starter fra begyndelsen af teksten

            // Looper gennem teksten og viser hvert bogstav
            while (startIndex < text.Length)
            {
                if (skip)
                {
                    // Hvis "skip" er true, viser resten af teksten med det samme
                    Console.Write(text.Substring(startIndex));
                    break;
                }

                Console.Write(text[startIndex]);
                startIndex++;  // Gå til næste bogstav
                Thread.Sleep(textSpeed);
            }

            Console.WriteLine(); 
        }

        // Metode til at tjekke for Enter tryk
        private void CheckForEnter(ref bool skip)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                skip = true;
            }
        }
        private void ShowTextFast(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(frustratedTextSpeed);
            }
        }
        public void EnterNextRoom()
        {
            string endingText = "Du svarer korrekt og føler en bølge af lettelse. Skikkelsen på tronen nikker langsomt og rejser sig.\n" +
                        "Han ser på dig med et skævt smil, og derefter bevæger han sig langsomt mod døren bag ham.\n" +
                        "Med et tilfreds blik rækker han hånden ud og åbner døren med et knirk. \n" +
                        "Du tager et skridt fremad, klar til at træde ind i det ukendte.\n";
            ShowTextSlowly(endingText);
            //Den afslører en ny vej, som lyser op i det dunkle rum.\n""Skikkelsen venter et øjeblik, som om han beder dig om at gå videre. Du har bestået denne prøve.
            Console.ReadLine();
            Console.Clear();
            nextRoom = new AnnettesRum();

            nextRoom.SøjleRummet();
        }
        
    }
}

