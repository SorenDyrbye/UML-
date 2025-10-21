
public class Customer
{

    #region Constructors
    public Customer(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;

    }
    #endregion

    #region Properties

    public string Name { get; private set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    #endregion

    #region Methods
    public void CustomerInfo()
    {
        Console.WriteLine($"Customer Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}");
    }

    public void OrderPizza(Pizza pizza,string orderTime, int orderNumber)
    {
        Order Order1 = new Order(this, orderTime, orderNumber, pizza);
        Console.WriteLine($"Order placed for {Name}: Pizza Nr {pizza.Nr}, which is {pizza.IngredientDescription} Size: {pizza.Size}, Price: {pizza.Price}, {pizza.VeganInfo}");
        double totalPrice = Order1.TotalPriceCalculation();
        Console.WriteLine($"The total cost of the order is {totalPrice}");

    }

    #endregion

}