﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TempleEscape
{

    //TEST 2 SKAL VÆRE HER
    //TEST SKAL VÆRE HER
    class TrillionRoom //: Room
    {

        TreasureRoom nextRoom;

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
            "2. Japan",
            "3. Sydkorea",
            "4. Indien"
        };

        public string questionCorrect = "%@#!...Godt gået!";

        public void StartTirllionRoom()
        {
            RoomIntro();
        }
        public void RoomIntro()
        {
            string introText = "Du befinder dig i et mørkt rum, belyst af flakkende fakler.\n\n" +
                            "Foran dig sidder en skikkelse på en trone. Silhuetten er mørk, men skærmen foran ham lyser hans ansigt op i et uhyggeligt skær.\n" +
                            "Foran ham er en stol, rettet mod skærmen. Du føler dig nærmest tvunget til at sætte dig i den... Der er dog en dør bag ham\n\n";
            ShowTextSlowly(introText);
            Console.WriteLine("Hvad vil du gøre?");
            Console.WriteLine("1: Sæt dig i stolen.");
            Console.WriteLine("2: Ignorér skikkelsen og gå mod døren bag ham.\n");

            Console.Write("Dit valg: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nDu sætter dig langsomt i stolen. Skærmen foran dig blinker til liv, og skikkelsen smiler skummelt...\n");
                Console.ReadLine();
                ShowTextSlowly(roomDescription);
                TirllionQuestion();
                // Kald en metode til næste scene
            }
            else if (choice == "2")
            {
                string ignorerHamText = "\nDu ignorerer stolen og bevæger dig mod døren. Skikkelsens blik følger dig, men han siger intet...\n";
                ShowTextSlowly(ignorerHamText);
                Console.ReadLine();
                IgnorerForsæt();
                // Kald en metode til en alternativ scene
            }
            else
            {
                Console.WriteLine("\nDu tøver, men skikkelsen stirrer afventende på dig. Du må vælge...\n");
            }
            Console.WriteLine("Med en rungende stemme taler skikkelsen:\n");

            Console.WriteLine("\n");
        }
        public void IgnorerForsæt()
        {
            string tilbageigenText = ("Det nye rum åbner op og du indser....\n");
            ShowTextSlowly(tilbageigenText);
            RoomIntro();
        }

        // metoden der bruger string variablerne ovenfor
        public void TirllionQuestion()
        {



            RoomQuestion(question + options);


            string userInput = Console.ReadLine();
            int userChoice;

            if (int.TryParse(userInput, out userChoice))  // Prøver at konvertere strengen til et heltal
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("\n NEJ!");
                    Console.ReadLine();
                    Console.Clear();
                    string tryAgainText = "\nPrøv igen...\n";
                    ShowTextSlowly(tryAgainText);
                    TirllionQuestion();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("\n HVAD MENER DU!?");
                    Console.ReadLine();
                    Console.Clear();
                    string tryAgainText = "\nPrøv igen...\n";
                    ShowTextSlowly(tryAgainText);
                    TirllionQuestion();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("\n NÆSTEN!..");
                    Console.ReadLine();
                    Console.Clear();
                    string tryAgainText = "\nPrøv igen...\n";
                    ShowTextSlowly(tryAgainText);
                    TirllionQuestion();
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


            Console.ReadKey();
            Console.ReadKey();

            //nextRoom = new TreasureRoom();

            //nextRoom.OpenTreasure();


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

            // Start en ny tråd til at lytte efter Enter-tastetryk
            Task.Run(() => CheckForEnter(ref skip)); // Passer referencen til skip variablen

            foreach (char letter in text)
            {
                if (skip)
                {
                    Console.Write(text.Substring(text.IndexOf(letter))); // Vis resten af teksten med det samme
                    break;
                }

                Console.Write(letter);
                Thread.Sleep(textSpeed);
            }
            Console.WriteLine(); // Gør klar til ny linje efter teksten
        }

        // Metode til at tjekke for Enter-tastetryk
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
            string endingText = "\nDu svarer korrekt og føler en bølge af lettelse. Skikkelsen på tronen nikker langsomt og rejser sig.\n" +
                        "Han ser på dig med et skævt smil, og derefter bevæger han sig langsomt mod døren bag ham.\n" +
                        "Med et tilfreds blik rækker han hånden ud og åbner døren med et knirk. Den afslører en ny vej, som lyser op i det dunkle rum.\n" +
                        "Skikkelsen venter et øjeblik, som om han beder dig om at gå videre. Du har bestået denne prøve.\n" +
                        "Du tager et skridt fremad, klar til at træde ind i det ukendte.\n";
            ShowTextSlowly(endingText);
            nextRoom = new TreasureRoom();

            nextRoom.OpenTreasure();
        }
    }
}

