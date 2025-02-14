using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleEscape
{
    class Game
    {
        TrillionRoom currentRoom;        

        public void Play()
        {
            currentRoom = new TrillionRoom();

            currentRoom.StartTirllionRoom();


        }
    }
}
