/*
 * Student ID : 1690704455
 * Name       : Kanokkorn Luesamut
 * Section    : 129D
 * No.        : 23
 * Course     : GI113 Computer Programming (GI)
 */
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //            อ่าน menu(char.TryParse)
         //อ่าน amount(double.TryParse)

         //ถ้า amount ถูกต้อง(parse ได้ และ 0 < amount <= MaxBatch)
         //    ถ้า menu คือ S หรือ s        → amount* SmeltRate    → แสดงเป็น Ingot
         //    ไม่งั้นถ้า menu คือ B หรือ b   → amount / SalvageRate  → แสดงเป็น Ore
         //    ไม่งั้น                        → แสดงว่า menu ไม่ถูกต้อง
         //ไม่งั้น                            → แสดงว่า amount ไม่ถูกต้อง

            const string IronName = "Iron";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 500;


            Console.WriteLine("+----------------------------------------------------------------------------+\r\n|                                                                            |\r\n| ░█░█░█▀▀░█░░░█▀▀░█▀█░█▄█░█▀▀░░░▀█▀░█▀█░░░▀█▀░█░█░█▀▀░░░█▀▀░█▀█░█▀▄░█▀▀░█▀▀ |\r\n| ░█▄█░█▀▀░█░░░█░░░█░█░█░█░█▀▀░░░░█░░█░█░░░░█░░█▀█░█▀▀░░░█▀▀░█░█░█▀▄░█░█░█▀▀ |\r\n| ░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀▀▀░░░░▀░░▀▀▀░░░░▀░░▀░▀░▀▀▀░░░▀░░░▀▀▀░▀░▀░▀▀▀░▀▀▀ |\r\n|                                                                            |\r\n+----------------------------------------------------------------------------+");
            Console.WriteLine("");
            Console.WriteLine("=> Iron Smelting 0.25 / Salvage 0.3");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("Chose Menu: ");
            bool menuChose = char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("How much woudl you like: ");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);

            if (isAmount && amount > 0 && amount <= MaxBatch)
            {
                if (menuChose && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.WriteLine($"Iron Ore: {amount}, Iron Ingot: {ingot}");
                }
                else if (menuChose && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine($"Iron Ore: {ore}, Iron Ingot: {amount}");
                }
                else
                {
                    Console.WriteLine("!!Menu not correct please try again!!");
                }
          
            }
            else
            {
                Console.WriteLine("!!Amount not correct please try again!!");
            }
            Console.WriteLine("\r\n                                      ██          ██                                    \r\n                                        ██      ██                                      \r\n                                      ████      ████                                    \r\n                                      ████      ████                                    \r\n                                                                                        \r\n                                          ██████                                        \r\n                                        ██      ██ ");
        }
    }
}
