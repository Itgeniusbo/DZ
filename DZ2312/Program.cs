using System;

namespace DZ2312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var undefined = 0;
            var mondey = 1;
            var thuesday = 2;
            var wednesday = 3;
            var tuesday = 4;
            var friday = 5;
            var saturday = 6;
            var sunday = 7;

            Console.WriteLine("Введите номер дня недели:");
            var number = int.Parse(Console.ReadLine() ?? "0");

            if (number == undefined)
            {
                Console.WriteLine("Введены некорректные данные");
            }
            else if (number == mondey)
            {
                Console.WriteLine("Понедельник");
            }
            else if (number == thuesday)
            {
                Console.WriteLine("Вторник");
            }
            else if (number == wednesday)
            {
                Console.WriteLine("Среда");
            }
            else if (number == tuesday)
            {
                Console.WriteLine("tuesday");
            }
            else if (number == friday)
            {
                Console.WriteLine("Пятница");
            }
            else if (number == saturday)
            {
                Console.WriteLine("Cуббота");
            }
            else if (number == sunday)
            {
                Console.WriteLine("Воскресенье");
            }
        }
    }
}




       
        
