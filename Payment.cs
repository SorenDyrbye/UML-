

    public class Payment
{
#region Constructors
    public Payment(string paymentMethod, bool isPaid)
    {
       PaymentMethod = paymentMethod;
       IsPaid = false;
    }

#endregion

#region Properties
    public string PaymentMethod { get; set; }
    public bool IsPaid { get; set; }

#endregion

#region Methods
    public void ProcessPayment()
    {
        IsPaid = true;
        Console.WriteLine($"Payment of {PaymentMethod} has been processed.");
    }

    #endregion


}

