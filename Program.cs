using System;
using System.Threading;

public class RanMtr
{
    static void Main()
    {
        Random ran = new Random();
        int x = ran.Next(10);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int count = 0;
        int line = 8;
        int loop = 0;
        while (loop < 7)
        {
            count = 0;
            while (count < 30)
            {
                for (int i = 0; i < 120; i++)
                {
                    Console.Write(ran.Next(10));
                }
                Console.Write("\n");
                Thread.Sleep(100);
                count++;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(54, i + line);
                Console.Write("0101");
            }
            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(62, i + line);
                Console.Write("0101");
            }
            for (int i = 15; i < 17; i++)
            {
                Console.SetCursorPosition(58, i + line);
                Console.Write("0101");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 30 - 8 + line);
            line += 30;
            loop++;
            //Console.ReadKey();
        }
        while (true)
        {
            count = 0;
            while (count < 30)
            {
                for (int i = 0; i < 120; i++)
                {
                    Console.Write(ran.Next(10));
                }
                Console.Write("\n");
                Thread.Sleep(100);

                count++;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(43, i + line);
                Console.Write("010");

            }
            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(49, i + line);
                Console.Write("010");

            }
            for (int i = 15; i < 17; i++)
            {
                Console.SetCursorPosition(46, i + line);
                Console.Write("101");
            }
            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(54, i + line);
                Console.Write("01");
            }
            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(60, i + line);
                Console.Write("01");
            }
            Console.SetCursorPosition(56, 12 + line);
            Console.Write("0101");

            Console.SetCursorPosition(56, 19 + line);
            Console.Write("0101");

            for (int i = 12; i < 20; i++)
            {
                Console.SetCursorPosition(64, i + line);
                Console.Write("01");
            }
            for (int i = 12; i < 17; i++)
            {
                Console.SetCursorPosition(68, i + line);
                Console.Write("01");
            }
            for (int i = 15; i < 20; i++)
            {
                Console.SetCursorPosition(74, i + line);
                Console.Write("01");
            }

            Console.SetCursorPosition(70, 12 + line);
            Console.Write("010101");
            Console.SetCursorPosition(68, 19 + line);
            Console.Write("010101");

            for (int i = 15; i < 17; i++)
            {
                Console.SetCursorPosition(70, i + line);
                Console.Write("0101");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 30 - 8 + line);
            line += 30;
            //Console.ReadKey();
        }
    }

}
