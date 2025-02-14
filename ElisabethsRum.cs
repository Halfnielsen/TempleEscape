using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;

namespace TempleEscape
{
        class ElisabethsRum
        {

            public void Elisabeth()

            {
                // korridoren opbevaret i et array
                string[] corridor =
                {
                "         ______         ",
                "         |    |         ",
                "         |   o|         ",
                "         |____|         ",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
                "|||||||||      |||||||||",
            };

                // printer korridoren
                for (int y = 0; y < corridor.Length; y++)
                {
                    Console.WriteLine(corridor[y]);
                }
                // spillerens position
                int playerX = corridor[0].Length / 2;
                int playerY = corridor.Length - 1;
                // skjuler cursoren
                Console.CursorVisible = false;
                // spilleren printes på positionen 
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("Ö");

                // spillerens movement
                while (true)
                {


                    if (Console.KeyAvailable)
                    {

                        // gemmer spillerens gamle position
                        int oldX = playerX;
                        int oldY = playerY;

                        // tjekker om spilleren har trykket på en tast
                        ConsoleKey key = Console.ReadKey(true).Key;

                        // spilleren går 1 hak op, når man trykker på pil op
                        if (key == ConsoleKey.UpArrow && playerY > 0)
                        {
                            playerY--;
                        }

                        // 'feltet' cursoren hover over sættes spillerens gamle position, og derefter udskrives det stykke korridor, der svarede til baggrunden der.
                        Console.SetCursorPosition(oldX, oldY);
                        Console.Write(corridor[oldY][oldX]);
                        // cursoren sættes til spillerens position post-pil op, og spilleren printes
                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write("Ö");

                        if (playerY == 3)
                        {
                            Console.Clear();

                            var replik = "Det er lang tid siden, nogen har gået gemmen den korridor. Godt klaret.";
                            foreach (var character in replik)
                            {
                                Console.Write(character);
                                Thread.Sleep(40);
                            }
                            var replik2 = "\nMen du kan ikke slappe af endnu.\nDu\nMå\nFørst\nSlå\n\nMIG\n";
                            foreach (var character in replik2)
                            {
                                Console.Write(character);
                                Thread.Sleep(90);
                            }


                            Console.WriteLine("Indtast tallet på det felt, du vil placere din brik.");
                            string[] tictactoe =
                            {
                                
                            };


                        }

                    }


                    // lille breather 
                    Thread.Sleep(100);
                }


            }
        }
    }

