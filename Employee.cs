public class Employee
{
    
#region constructors
    public Employee(string name, string role)
    {
        Name = name;
        Role = role;
    }

#endregion

#region properties
    public string Role { get; set; }

    public string Name { get; }

#endregion

#region methods

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Role: {Role}");
    }

#endregion

}