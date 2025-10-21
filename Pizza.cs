
    public class Pizza
    {
   
    #region Constructors
    public Pizza(int nr, double price, string size, bool isVegan, string ingredientDescription)
    {
        Nr = nr;
        Price = price;
        Size = size;
        IsVegan = isVegan;
        IngredientDescription = ingredientDescription;
    } 

    #endregion

    #region Properties
    public int Nr 
    { get; set; }

    public double Price
    { get; set; }

    public string Size
    {get; set;} 

    public bool IsVegan
    {get; set;}

    public string IngredientDescription
    { get; set; }

    public string VeganInfo
    {
        get
        {
            if (IsVegan)
            {
                return "This pizza is vegan.";
            }
            else
            {
                return "This pizza is not vegan.";
            }
        }
    }


    #endregion

    #region Methods
    public void ChangeNumber(int newNr)
    {
        Nr = newNr;
        return;
    }

    public void ChangePrice(int newPrice)
    {
        Price = newPrice;
        return;
    }

    public void ChangeIngredientDescription(string newIngredientDescription)
    {
        IngredientDescription = newIngredientDescription;                
        return;
    }
    #endregion

    public string PrintInfo()
    {
        return $"Pizza Nr: {Nr}, Price: {Price}, Size: {Size}, IsVegan: {IsVegan}, Ingredients: {IngredientDescription}";
    }


}

