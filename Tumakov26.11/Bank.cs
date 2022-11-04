using System;


namespace Tumakov26._11
{
    public class Bank
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }

        public int Transfer(ref Bank bank, double a)
        {
            double b = bank.Balance;
            if (bank.Balance >= a)
            {
                bank.Balance = bank.Balance - a;
                Console.WriteLine($"Счет до операции: {b}$\nТекущий счет: {bank.Balance}$");
            }
            else
            {
                Console.WriteLine("На вашем счету недостаточно средств!!!");
            }
            return 0;
        }


    }
}
