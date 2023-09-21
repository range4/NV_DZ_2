using System;


namespace lab3
{
    internal class Program
    {
        enum BankAccountType
        {
            Текущий,
            Сберегательный
        }

        struct BankAccount
        {
            public long ID;
            public BankAccountType Type;
            public int Balance;

        }
        struct User
        {
            public string Name;
            public Vuz Vuz;
        }
        enum Vuz
        {
            КГУ,
            КАИ,
            КХТИ
        }
        static void Main(string[] args)
        {
            BankAccountType acctype = BankAccountType.Сберегательный;
            Console.WriteLine($"Тип вашего банковского счёта : {acctype}\n");

            BankAccount user = new BankAccount();
            user.ID = 777000777;
            user.Type = BankAccountType.Сберегательный;
            user.Balance = 44440000;

            Console.WriteLine($"Номер вашего банковского счета : {user.ID}\nТип вашего банковского счета : {user.Type}\nВаш баланс : {user.Balance}\n");

            User usr = new User();
            usr.Name = "Вася";
            usr.Vuz = Vuz.КХТИ;

            Console.WriteLine($"Работник ВУЗа : {usr.Name}\nВУЗ : {usr.Vuz}\n");


        }
    }
}