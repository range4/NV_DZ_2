using System;
using System.Threading;



namespace programs8
{

    struct User
    {
        public string name;
        public string city;
        public int age;
        public string pin;
        public void Print()
        {
            Console.WriteLine($"Имя пользователя: {name}\nМесто жительства пользователя: {city}\nВозраст пользователя: {age}\nПин-код пользователя: {pin}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задача 1\nbyte - максимальное значение: {byte.MaxValue}, минимальное значение: {byte.MinValue} \n" +
                              $"sbyte - максимальное значение: {sbyte.MaxValue}, минимальное значение: {sbyte.MinValue} \n" +
                              $"short - максимальное значение: {short.MaxValue}, минимальное значение: {short.MinValue} \n" +
                              $"ushort - максимальное значение: {ushort.MaxValue}, минимальное значение: {ushort.MinValue} \n" +
                              $"int - максимальное значение: {int.MaxValue}, минимальное значение: {int.MinValue} \n" +
                              $"uint - максимальное значение: {uint.MaxValue}, минимальное значение: {uint.MinValue} \n" +
                              $"long - максимальное значение: {long.MaxValue}, минимальное значение: {long.MinValue} \n" +
                              $"ulong - максимальное значение: {ulong.MaxValue}, минимальное значение: {ulong.MinValue} \n" +
                              $"float - максимальное значение: {float.MaxValue}, минимальное значение: {float.MinValue} \n" +
                              $"double - максимальное значение: {double.MaxValue}, минимальное значение: {double.MinValue} \n" +
                              $"decimal - максимальное значение: {decimal.MaxValue}, минимальное значение: {decimal.MinValue} \n" +
                              $"char - максимальное значение: {char.MaxValue}, минимальное значение: {char.MinValue}\n");

            Console.WriteLine("Задача 2\n");
            User user = new User();
            Console.WriteLine("Введите ваше имя: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Введите ваш город: ");
            user.city = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            user.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Придумайте пин-код: ");
            user.pin = Console.ReadLine();
            user.Print();

            Console.WriteLine("Задача 3\nВведите строку: ");
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length;i++)
            {
                if (Char.IsLower(charArray[i]))
                    charArray[i] = char.ToUpper(charArray[i]);
                else
                    charArray[i] = char.ToLower(charArray[i]);
            }
            s = new string(charArray);
            Console.WriteLine($"Преобразованная строка: {s}");


            Console.WriteLine("Задача 6\nКак твое имя, волшебник?");
            Console.WriteLine($"Приветствую,{Console.ReadLine()}");
            string que1 = Console.ReadLine();
            if (que1 == "Знаешь ли ты что-то о тайной комнате?")
            {
                Console.WriteLine("Да");
                string que2 = Console.ReadLine();
                if (que2 == "Можешь ли ты что-то о ней рассказать?")
                {
                    Console.WriteLine("Нет");
                    Thread.Sleep(5000);
                    Console.WriteLine("Но могу показать...");
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }
            
        }
    } 
}