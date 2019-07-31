using System;
using System.Threading;

//nhược điểm: khó chỉnh sửa dòng chữ đỏ được in đè lên ma trận xanh

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
            while (count < 30) // in ra 30 dòng ngẫu nhiên
            {
                for (int i = 0; i < 120; i++)
                {
                    Console.Write(ran.Next(10)); // trên mỗi dòng in ra 120 kí tự số ngẫu nhiên
                }
                Console.Write("\n");
                Thread.Sleep(100); // dừng lại 0.1s rồi thực hiện tiếp câu lệnh sau
                count++;
            }
            // đưa con trỏ về vị trí thích hợp để in ra chữ H màu đỏ
            #region Red_H
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
            #endregion
            //đưa con trỏ chuột về vị trí tiếp tục tạo số ngẫu nhiên màu xanh 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 30 - 8 + line); //ban đầu đoạn code trên được viết để hiện chữ H 
                                                         //ở khoảng chính giữa màn hình Console, khởi tạo line = 8 để đẩy 
                                                         //chữ H xuống phía dưới
            line += 30;
            loop++; 
        }
        while (true) //vòng lặp vô hạn in ra đoạn chữ đỏ HOIS
        {
            count = 0;
            while (count < 30) //in ra 30 dòng số ngẫu nhiên rồi tiếp tục in chữ đỏ
            {
                for (int i = 0; i < 120; i++)
                {
                    Console.Write(ran.Next(10));
                }
                Console.Write("\n");
                Thread.Sleep(100);

                count++;
            }
            #region Red_HOIS
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
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 30 - 8 + line);
            line += 30;
        }
    }
}
