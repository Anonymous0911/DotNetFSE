using System;

class Program
{
    static Product? LinearSearch(Product[] products, int targetId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }

        return null;
    }

    static Product? BinarySearch(Product[] products, int targetId)
    {

        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (products[mid].ProductId == targetId)
                return products[mid];

            if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Mouse", "Accessories"),
            new Product(103, "Keyboard", "Accessories"),
            new Product(104, "Phone", "Electronics"),
            new Product(105, "Tablet", "Electronics")
        };

        int targetId = 104;

        Product? linearResult = LinearSearch(products, targetId);

        if (linearResult != null)
            Console.WriteLine("Linear Search Result:");
        Console.WriteLine(linearResult);

        Product? binaryResult = BinarySearch(products, targetId);

        if (binaryResult != null)
            Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine(binaryResult);
    }
}