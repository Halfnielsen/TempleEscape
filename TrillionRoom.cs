using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TempleEscape
{

    
    class TrillionRoom //: Room
    {
        
        TreasureRoom nextRoom;

        private int textSpeed = 50;
        private int frustratedTextSpeed = 5;
        private int correctAnswer = 2;


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

        public string questionCorrect = "Satans!";

        // metoden der bruger string variablerne ovenfor
        public void TirllionQuestion()
        {
            
            ShowTextSlowly(roomDescription);

            Console.WriteLine("\n" + question);

            foreach (var choice in options)
            {
                Console.WriteLine(choice);
            }
            Console.Write("\n");

            Console.ReadLine();

            if (correctAnswer > 2)
            {
               Console.Write( "\n nææææ");

            }
            else
            {
                Console.Clear();
                ShowTextFast(questionCorrect);
            }
            

            Console.ReadKey();
            Console.ReadKey();

            //nextRoom = new TreasureRoom();

            //nextRoom.OpenTreasure();


        }

        //Vis tekst langsommere
        private void ShowTextSlowly(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(textSpeed);
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
    }
}

