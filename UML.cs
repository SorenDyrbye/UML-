
Employee medarbejder1 = new("Rasmus", "kok");
Employee medarbejder2 = new("Christian", "Ejer");
Employee medarbejder3 = new("Søren", "Tjener");

medarbejder1.ShowInfo();
medarbejder2.ShowInfo();
medarbejder3.ShowInfo();

Pizza pepperoni = new Pizza(1, 109, "Normal", false, "Pizza med pepperoni og ost");
Pizza ost = new Pizza(2, 99, "Normal", false, "Pizza med ost og tomatsauce");
Pizza vegan = new Pizza(3, 129, "Normal", true, "Pizza med vegansk ost og grøntsager");
Pizza hawaii = new Pizza(4, 119, "Normal", false, "Pizza med skinke og ananas");
Pizza kødsovs = new Pizza(5, 139, "Normal", false, "Pizza med kødsovs og ost");

pepperoni.PrintInfo();
ost.PrintInfo();
vegan.PrintInfo();
hawaii.PrintInfo();
kødsovs.PrintInfo();

Console.WriteLine();

Customer Customer1 = new Customer("Hans","58375963", "hans@gmail.com");
Customer Customer2 = new Customer("Sarah", "29384756", "sarah@gmail.com");
Customer Customer3 = new Customer("Michael", "12345678", "michael@gmail.com");

Customer1.CustomerInfo();
Customer2.CustomerInfo();
Customer3.CustomerInfo();

Console.WriteLine();

Customer1.OrderPizza(kødsovs, "12:30", 1);
Console.WriteLine();
Customer2.OrderPizza(vegan, "13:00", 2);
Console.WriteLine();
Customer3.OrderPizza(pepperoni, "13:30", 3);