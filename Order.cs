
public class Order
{
    const double vat = 1.25;
    const double deliveryCosts = 40;

    private Pizza _pizzaInOrder;
    private Customer _customer;

    #region Constructors
    public Order(Customer customer,string orderTime, int orderNumber, Pizza pizza)
    {
        OrderTime = orderTime;
        OrderNumber = orderNumber;
        _pizzaInOrder = pizza;
        _customer = customer;
        IsReady = false;
    }
    #endregion

    #region Properties
    public string OrderTime { get; set; }
    public int OrderNumber { get; set; }
    public double TotalPrice { get; set; }
    public bool IsReady { get; set; }
    #endregion

    #region Methods
    public double TotalPriceCalculation()
    {
        double totalPrice = (_pizzaInOrder.Price + deliveryCosts) * vat;
        return totalPrice;
    }

    #endregion
}

