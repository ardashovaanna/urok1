using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите первое число для сложения(вычитания):");
            string m = Console.ReadLine();
            double a = Convert.ToDouble(m);

            Console.WriteLine("Введите второе число для сложения(вычитания):");
            string n = Console.ReadLine(); 
           double b = Convert.ToDouble(n);

            double c = a + b;
            Console.WriteLine("Сумма данных чисел:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(c) ; 
            Console.ResetColor();


            double r = a - b;
            Console.WriteLine("Разность данных чисел:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(r);
            Console.ResetColor();

            double p = a * b;
            Console.WriteLine("Произведение данных чисел:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(p);
            Console.ResetColor();

            double o = a / b;
            Console.WriteLine("Частное данных чисел:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(o);
            Console.ResetColor();

            Console.ReadLine();

          
           

        }



    }
}
