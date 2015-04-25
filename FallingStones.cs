using System;
using System.Threading;
using System.Threading.Tasks;

//In this implementation the player can move in all directions
//Only one stone is falling, with random color and random position
//TODO:
//1.Colision detection should be implemented
//2.Falling stone different sizes, forms and quantity should be implemented
//3.Scoring system should be implemented

class FallingStones
{
    static string symbolPlayer = "(E)";
    static char symbolStone = '\u2588';

    static int x = 15;      // Start point PlayerX
    static int y = 29;      // Start point PlayerY

    static int a = 0;       // Start point StoneX
    static int b = 0;       // Start point StoneX

    static ConsoleColor color = ConsoleColor.Yellow;

    static void Main()
    {
        Console.Title = "FallingStones";
        Console.CursorVisible = false;

        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 30;

        while (true)
        {
            DrawPlayer(x, y, symbolPlayer);
            DrawStone(a, b, symbolStone, color);

            Thread.Sleep(200);
            Console.Clear();

            MoveStone();
            MovePlayer();
        }
    }

    private static void DrawPlayer(int x, int y, string symbolPlayer)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x, y);
        Console.Write(symbolPlayer);
    }

    private static void DrawStone(int a, int b, char symbolStone, ConsoleColor color)
    {
        Console.SetCursorPosition(a, b);
        Console.ForegroundColor = color;
        Console.Write(symbolStone);
    }

    private static void MoveStone()
    {
        b++;

        if (b == Console.WindowHeight)
        {
            b = 0;

            Random number_1 = new Random();
            a = number_1.Next(0, Console.WindowWidth);

            StoneColor();
        }
    }
    private static void MovePlayer()
    {
        if (Console.KeyAvailable == true)
        {
            ConsoleKeyInfo enter = Console.ReadKey();

            Console.Beep(196, 50);

            if (enter.Key == ConsoleKey.LeftArrow && x != 0)
            {
                x--;

                DrawPlayer(x, y, symbolPlayer);
            }

            if (enter.Key == ConsoleKey.RightArrow && x != (Console.WindowWidth - 3))
            {
                x++;

                DrawPlayer(x, y, symbolPlayer);
            }

            if (enter.Key == ConsoleKey.UpArrow && y != 0)
            {
                y--;

                DrawPlayer(x, y, symbolPlayer);
            }

            if (enter.Key == ConsoleKey.DownArrow && y != (Console.WindowHeight - 1))
            {
                y++;

                DrawPlayer(x, y, symbolPlayer);
            }
        }
    }

    private static ConsoleColor StoneColor()
    {
        Random number_2 = new Random();
        int colorNum = number_2.Next(0, 14);

        #region colorNum
        if (colorNum == 0)
        {
            color = ConsoleColor.Blue;
        }
        else if (colorNum == 1)
        {
            color = ConsoleColor.Cyan;
        }
        else if (colorNum == 2)
        {
            color = ConsoleColor.DarkBlue;
        }
        else if (colorNum == 3)
        {
            color = ConsoleColor.DarkCyan;
        }
        else if (colorNum == 4)
        {
            color = ConsoleColor.DarkGray;
        }
        else if (colorNum == 5)
        {
            color = ConsoleColor.DarkGreen;
        }
        else if (colorNum == 6)
        {
            color = ConsoleColor.DarkMagenta;
        }
        else if (colorNum == 7)
        {
            color = ConsoleColor.DarkRed;
        }
        else if (colorNum == 8)
        {
            color = ConsoleColor.DarkYellow;
        }
        else if (colorNum == 9)
        {
            color = ConsoleColor.Gray;
        }
        else if (colorNum == 10)
        {
            color = ConsoleColor.Green;
        }
        else if (colorNum == 11)
        {
            color = ConsoleColor.Magenta;
        }
        else if (colorNum == 12)
        {
            color = ConsoleColor.White;
        }
        else if (colorNum == 13)
        {
            color = ConsoleColor.Yellow;
        }
        #endregion

        return color;
    }
}



