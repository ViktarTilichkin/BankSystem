namespace BankSystem.Models;

public class ExchangeRate
{
    public int CurrencyFrom { get; set; }
    public int CurrencyTo { get; set; }
    public double Rate { get; set; }

    public ExchangeRate(int currencyFrom, int currencyTo, double rate)
    {
        CurrencyFrom = currencyFrom;
        CurrencyTo = currencyTo;
        Rate = rate;
    }

    public override string ToString()
    {
        return $"{Rate}";
    }
}