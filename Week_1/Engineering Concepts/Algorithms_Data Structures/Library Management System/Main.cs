using System;

class Program
{
    static Book? LinearSearch(Book[] books, string targetTitle)
    {
        foreach (Book book in books)
        {
            if (book.Title.Equals(targetTitle,
                    StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }

        return null;
    }

    static Book? BinarySearch(Book[] books, string targetTitle)
    {
        int left = 0;
        int right = books.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int comparison =
                string.Compare(books[mid].Title,
                               targetTitle,
                               StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return books[mid];

            if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Book[] books =
        {
            new Book(101, "C#", "Microsoft"),
            new Book(102, "Java", "James Gosling"),
            new Book(103, "Python", "Guido van Rossum"),
            new Book(104, "SQL", "Donald Chamberlin")
        };

        Console.WriteLine("Linear Search:");
        Book? result1 = LinearSearch(books, "Python");

        if (result1 != null)
            Console.WriteLine(result1);
        else
            Console.WriteLine("Book not found.");

        Console.WriteLine("\nBinary Search:");
        Book? result2 = BinarySearch(books, "Python");

        if (result2 != null)
            Console.WriteLine(result2);
        else
            Console.WriteLine("Book not found.");
    }
}