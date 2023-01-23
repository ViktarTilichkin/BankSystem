using System;
using BankSystem.Models;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<ExchangeRate> rates = new List<ExchangeRate>();
            User user1 = new User(1, "test");
            // User user2 = user1;
            // Currency currency = new Currency((int)CurrencyCod.USD, "USA Dollar", "$", CurrencyCod.USD.ToString());
            // Console.WriteLine(currency);
            // rates.Add(new ExchangeRate((int)CurrencyCod.BYN, (int)CurrencyCod.USD, 0.38));
            // rates.Add(new ExchangeRate((int)CurrencyCod.BYN, (int)CurrencyCod.EUR, 0.35));
            // rates.Add(new ExchangeRate((int)CurrencyCod.BYN, (int)CurrencyCod.GBP, 0.33));
            // rates.Add(new ExchangeRate((int)CurrencyCod.USD, (int)CurrencyCod.BYN, 2.62));
            // rates.Add(new ExchangeRate((int)CurrencyCod.EUR, (int)CurrencyCod.BYN, 2.82));
            // rates.Add(new ExchangeRate((int)CurrencyCod.PLN, (int)CurrencyCod.BYN, 0.062));
            // rates.Add(new ExchangeRate((int)CurrencyCod.GBP, (int)CurrencyCod.BYN, 2.99));
            // Console.WriteLine(rates.Count);    
            // Console.WriteLine(rates.FirstOrDefault(x => x.CurrencyFrom == (int)CurrencyCod.BYN && x.CurrencyTo == (int)CurrencyCod.USD));

            var test = new OutClass<User, int>(user1, 5);
            Console.WriteLine(test.GetPropertyT());
            var usertest = test.GeneraitObjT();
            Console.WriteLine(usertest);
        }
    }
}