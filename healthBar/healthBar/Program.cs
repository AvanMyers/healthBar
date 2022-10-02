using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healtPercent = 0;
            int manaPercent = 0;
            int barWidth = 10;

            Console.WriteLine("Введите процент вашего ХП: ");
            healtPercent= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент вашего МП: ");
            manaPercent = Convert.ToInt32(Console.ReadLine());
            drowBar(healtPercent, barWidth, 0, 5, '/', '_', ConsoleColor.Red);
            drowBar(manaPercent, barWidth, 0, 6, '/', '_', ConsoleColor.Blue);
            Console.ReadKey();
        }

        static void drowBar(int valuePercent, int barWidth, int xAxis, int yAxis, char drawSimbol, char emptySimbol, ConsoleColor color)
        {
            ConsoleColor defoultColor = Console.BackgroundColor;
            string bar = "";
            int valueBarProcent = valuePercent / barWidth;

            for (int i = 0; i < valueBarProcent; i++)
            {
                bar += drawSimbol;
            }

            Console.SetCursorPosition(xAxis, yAxis);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defoultColor;

            bar = "";

            for (int i = valueBarProcent; i < barWidth; i++)
            {
                bar += emptySimbol;
            }

            Console.WriteLine(bar + "]");
        }
    }
}
