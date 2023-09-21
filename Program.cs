using System;

namespace NV_DZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков лаб 2\nУпражнение 2.1\nВведите своё имя:");
            Console.WriteLine($"Привет, {Console.ReadLine()}\n");



            Console.WriteLine("Упражнение 2.2\nВведите два числа чтобы узнать результат деления первого на второе: ");
            var first_num = decimal.Parse(Console.ReadLine());
            var second_num = decimal.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine($"Результат деления : {first_num / second_num}\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на 0 нельзя!");
            }


            Console.WriteLine("Домашнее задание 2.1\nНажмите на букву на клавиатуре : ");
            char letter = Console.ReadKey().KeyChar;
            if (letter != 'я' & letter != 'Я' & letter != 'z' & letter != 'Z')
                {
                    Console.WriteLine($"\nСледующая буква : {(char)(letter + 1)}");
                }

            else
            {
                Console.WriteLine("\nК сожалению, это последняя буква алфавита");
            }

            Console.WriteLine("Домашнее задание 2.2 - Квадратное уравнение");
            Console.Write("Enter value for a: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            var c = double.Parse(Console.ReadLine());
            double x1, x2;
            var D = (b*b - 4 * a * c); /// discriminant
            if (D < 0)
            {
                Console.WriteLine("no solutions");
            }
            else
            {
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }
                Console.WriteLine($" x1 = {x1} x2 = {x2}");
            }



        }
    }
}