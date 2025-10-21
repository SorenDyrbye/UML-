
    public class Exstra_toppins
{

#region Constructors
    public Exstra_toppins(string name, double price)
    {
        Name = name;
        Price = price;
    }
#endregion

#region Properties
    public string Name { get;}
    public double Price { get; set; }

#endregion

#region Methods
    public string ToppinsInfo()
    {
        return $"Toppins Name: {Name}, Price: {Price}";
    }

    #endregion

}


