using System;

class Program
{
    static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(orders, low, high);

            QuickSort(orders, low, pivotIndex - 1);
            QuickSort(orders, pivotIndex + 1, high);
        }
    }

    static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp1 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp1;

        return i + 1;
    }

    static void DisplayOrders(Order[] orders)
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(order);
        }
    }

    static void Main()
    {
        Order[] orders =
        {
            new Order(101, "Aaquib", 2500),
            new Order(102, "Rahul", 1200),
            new Order(103, "Aman", 3500),
            new Order(104, "Priya", 1800)
        };

        Console.WriteLine("Before Sorting:");
        DisplayOrders(orders);

        BubbleSort(orders);

        Console.WriteLine("\nAfter Bubble Sort:");
        DisplayOrders(orders);

        QuickSort(orders, 0, orders.Length - 1);

        Console.WriteLine("\nAfter Quick Sort:");
        DisplayOrders(orders);
    }
}