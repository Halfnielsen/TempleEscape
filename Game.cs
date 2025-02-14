using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleEscape
{
    class Game
    {
        TreasureRoom currentRoom;        

        public void Play()
        {
            currentRoom = new TreasureRoom();

            currentRoom.OpenTreasure();


        }
    }
}
