using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<int, Product> products;

    public Inventory()
    {
        products = new Dictionary<int, Product>();
    }

    // Add Product
    public void AddProduct(Product product)
    {
        if (!products.ContainsKey(product.ProductId))
        {
            products.Add(product.ProductId, product);
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Product ID already exists.");
        }
    }

    // Update Product
    public void UpdateProduct(int id, int quantity, double price)
    {
        if (products.ContainsKey(id))
        {
            products[id].Quantity = quantity;
            products[id].Price = price;
            Console.WriteLine("Product updated successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    // Delete Product
    public void DeleteProduct(int id)
    {
        if (products.Remove(id))
        {
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    // Display Inventory
    public void DisplayProducts()
    {
        Console.WriteLine("\nInventory:");
        foreach (var product in products.Values)
        {
            Console.WriteLine(product);
        }
    }
}