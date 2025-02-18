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
                            Thread.Sleep(10);
                        }
                        var replik2 = "\nMen du kan ikke slappe af endnu.\nDu\nMå\nFørst\nBesejre\n\nMIG\n";
                        foreach (var character in replik2)
                        {
                            Console.Write(character);
                            Thread.Sleep(90);
                        }


                        // gemmer boardets tomme felter i et array
                        char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

                     

                        // printer boardet
                        void PrintBoard()
                        {

                            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
                            Console.WriteLine("---|---|---");
                            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
                            Console.WriteLine("---|---|---");
                            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");

                        }

                        // tjekker om der er 3 på stribe, og hvis der er, hvem har vundet
                        bool CheckWin(char mark)
                        {
                            // vandrette rækker
                            if (board[0] == mark && board[1] == mark && board[2] == mark) return true;
                            if (board[3] == mark && board[4] == mark && board[5] == mark) return true;
                            if (board[6] == mark && board[7] == mark && board[8] == mark) return true;

                            // lodrette kolonner
                            if (board[0] == mark && board[3] == mark && board[6] == mark) return true;
                            if (board[1] == mark && board[4] == mark && board[7] == mark) return true;
                            if (board[2] == mark && board[5] == mark && board[8] == mark) return true;

                            // diagonaler
                            if (board[0] == mark && board[4] == mark && board[8] == mark) return true;
                            if (board[2] == mark && board[4] == mark && board[6] == mark) return true;

                            return false;
                        }
                        // spillerens træk - når spilleren indtaster et tal mellem 1 og 9, og feltet er tomt, sættes spillerens brik i feltet
                        void PlayerMove()
                        {
                            int move;
                            while (true)
                            {
                                Console.WriteLine("Indtast tallet på det felt, hvor du vil placere din brik.");
                                string input = Console.ReadLine() ?? "";
                                if (int.TryParse(input, out move) && move >= 1 && move <= 9 && board[move - 1] == ' ')
                                {
                                    board[move - 1] = 'X';
                                    break;
                                }
                                Console.WriteLine("Ugyldigt træk. Prøv igen.");

                            }
                        }

                        // bossens træk - bossen udfører et forudbestemt træk, hvis feltet er tomt
                        void BossMove()
                        {
                            int[] bossMoves = { 5, 4, 6, 9, 2 };
                            foreach (int move in bossMoves)
                            {
                                if (board[move - 1] == ' ')
                                {
                                    board[move - 1] = 'O';
                                    Thread.Sleep(500);
                                    break;
                                }
                            }
                            // lille breather 
                            Thread.Sleep(100);
                        }

                        // spiller loopet - spillet kører indtil spilleren eller bossen vinder
                        while (true)
                        {
                            PrintBoard();
                            PlayerMove();
                            // tjekker win hos spilleren og printer besked, hvis spilleren vinder
                            if (CheckWin('X'))
                            {
                                Console.Clear();
                                var bossTabte = "Du vandt... Endelig.. \nEndelig er jeg fri... \nOg du er det samme...";
                                foreach (var character in bossTabte)
                                {
                                    Console.Write(character);
                                    Thread.Sleep(1);
                                }
                               
                                var punktum = "\n...";
                                foreach (var character  in punktum)
                                {
                                    Console.Write(character);
                                    Thread.Sleep(1000);
                                }
                                Console.Clear();
                                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░████████████████████████████████████████████████████████████████████████████████████████████████░░\r\n░░████████████████████████████████████████████████████████████████████████████████████████████████░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓███████████████████████████▒▓████████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████████████████████████████████████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████████████████████████████▒▒▓▓▓▓▓▓█▓▓▒▓▓█████▒▒▒▒▒▒▒▒▒▒▒▒░▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▓▓█▓▒▒▒▓▒▒▒▒▒▒▒▒▓█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▒█▒▒▒▒▓▒▒▓▒▒▒▒▒▓█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▒█▒▒▒▒▓▒▒▓▒▒▒▒▒▓█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓█▒▒▒▒▓▒▓▓▒▒▒▒▓██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓█▒▒▒▒▓▒▓▓▒▒▒▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▒█▓▓▓▓▓▒▓▓▒▒▒▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▒▓▓▓▓▓█▒▓▓▒▒▒▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓██████▒▓▓▓▓▓▓▓██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓█▒▒▒▓█▓██▒▒▒▒▓██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓█▒▒▒▓█▓▓█▓▓▒▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓█▒▒▒▓█▒▓▓██▓▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████░░░░░░░░░░░░░░░░░░░░███▓▒▓▓▒▒▒▓█▓▓▓▓█▓▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███▓▓▓██▓▒▒███████▓▓██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████████████████████████████████▓▓▓▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████████████████████████████████████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████████████████████▓▓██▓▓▒▒███████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░████████████████████████████████████████████████████████████████████████████████████████████████░░\r\n░░████████████████████████████████████████████████████████████████████████████████████████████████░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                                break;

                            }
                            // tjekker win hos bossen og printer besked, hvis bossen vinder
                            BossMove();
                            if (CheckWin('O'))
                            {
                                Console.Clear();
                                var bossVandt = "Haha... Mennesker bliver aldrig klogere.";
                                foreach (var character in bossVandt)
                                {
                                    Console.Write(character);
                                    Thread.Sleep(40);
                                }                              
                                break;
                            }
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}

