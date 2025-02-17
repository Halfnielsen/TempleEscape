using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleEscape
{
    class Game
    {
        KhadrasRum currentRoom;        

        public void Play()
        {
            currentRoom = new KhadrasRum();

            currentRoom.FørsteRum();


        }
    }
}
