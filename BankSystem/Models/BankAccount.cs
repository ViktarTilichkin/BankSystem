namespace BankSystem.Models;

public class BankAccount
{
    public double NumberAcc { get; set; }
    public CurrencyCod Currency { get; set; }
    public double Money { get; private set; }
    public User UserId { get; set; }
    public int BankCode { get; set; }

    public List<ILimit> Limits { get; } = new List<ILimit>();

    public BankAccount()
    {

    }
    public BankAccount(double numberACC, CurrencyCod currency, double money, User userId, int bankCode)
    {
        NumberAcc = numberACC;
        Currency = currency;
        Money = money;
        UserId = userId;
        BankCode = bankCode;
    }
}