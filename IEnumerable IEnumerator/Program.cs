using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public int Price { get; set; }

    public Book(string title, int price)
    {
        this.Title = title;
        this.Price = price;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };

        foreach (var item in intArray)
        {
            Console.WriteLine(item);
        }

        Book[] bookArray = new Book[] {
            new Book("책 이름", 10000),
            new Book("가나다", 5000),
        };
    }
}
