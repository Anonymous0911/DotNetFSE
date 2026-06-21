using System;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(new Product(101, "Laptop", 10, 50000));
        inventory.AddProduct(new Product(102, "Mouse", 50, 500));

        inventory.DisplayProducts();

        inventory.UpdateProduct(101, 15, 52000);

        inventory.DisplayProducts();

        inventory.DeleteProduct(102);

        inventory.DisplayProducts();
    }
}