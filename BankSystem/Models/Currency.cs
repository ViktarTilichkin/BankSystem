namespace BankSystem.Models;

public class Currency
{
    public int Code { get; }
    public string Name { get; }
    public string Symbol { get; set; }
    public string ShortName { get; set; }

    public Currency()
    {

    }
    public Currency(int code, string name, string symbol, string shortName)
    {
        Code = code;
        Name = name;
        Symbol = symbol;
        ShortName = shortName;
    }

    public override string ToString()
    {
        return $"{Name} ({ShortName})";
    }
}