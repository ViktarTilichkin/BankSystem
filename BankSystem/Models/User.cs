namespace BankSystem.Models;

public class User
{
    public int Id { get; } = 2;
    public string Name { get; set; } = "No name";

    public User(int id)
    {
        Id = id;
    }
    public User()
    {

    }
    public User(int id, string name) : this(id)
    {
        Name = name;
    }
    public override bool Equals(object? obj)
    {
        if (base.Equals(obj))
        {
            return true;
        }
        if (obj == null || obj is not User)
        {
            return false;
        }
        User user = (User)obj;
        return this.Id == user.Id && this.Name == user.Name;
    }

    public override int GetHashCode()
    {
        return Id * 1000 + Name.Length;
    }
    public override string ToString()
    {
        return $"Name {Name} Id {Id}";
    }
}