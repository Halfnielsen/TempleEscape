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
        // Spørgsmålet og svarmulighederne
        TreasureRoom nextRoom;

        private int textSpeed = 50;
        private int correctAnswer = 2;


        // Rum specifik beskrivelse
        public string roomDescription = "Velkommen fremmede! Besvar spørgsmålet!";        
        private string question = "Hvilket land er kendt som 'The Land of the Rising Sun'?";
        private string[] options = new string[] 
        {
            "1. Kina",
            "2. Japan",
            "3. Sydkorea",
            "4. Indien"
        };


        // Handling, når spilleren træder ind i dette rum
        public void TirllionQuestion()
        {
            ShowTextSlowly(roomDescription);
            Console.WriteLine("\n" + question);
            foreach (var choice in options)
            {
                Console.WriteLine(choice);
            }

            Console.ReadKey();
            nextRoom = new TreasureRoom();

            nextRoom.OpenTreasure();


        }

        private void ShowTextSlowly(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(textSpeed);
            }
        }
    }
}

