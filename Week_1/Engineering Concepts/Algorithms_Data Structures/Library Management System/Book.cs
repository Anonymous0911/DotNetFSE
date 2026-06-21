using System;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"ID: {BookId}, Title: {Title}, Author: {Author}";
    }
}