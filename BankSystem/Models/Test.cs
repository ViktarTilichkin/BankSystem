using static System.Net.Mime.MediaTypeNames;

namespace BankSystem.Models;

public class OutClass<T, K> where T : class , new()
{
    private T PropertyT;
    private K PropertyK;

    public OutClass(T propertyT, K propertyK)
    {
       // if (propertyT == null) throw new ArgumentNullException(nameof(propertyT));

        PropertyT = propertyT;
        PropertyK = propertyK;
    }

    public void Show()
    {
        Console.WriteLine($"{PropertyT.ToString()} ");
    }
    public T GetPropertyT()
    {
        return PropertyT;
    }
    public void SetPropertyT(T propertyT)
    {
        PropertyT = propertyT;
    }
    public K GetPropertyK()
    {
        return PropertyK;
    }
    public T GeneraitObjT()
    {
        return new T();
    }
}
