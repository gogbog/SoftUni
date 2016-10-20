using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library libraries = new Library();
            

            for (int i = 0; i < n; i++)
            {
                string[] inputedInfo = Console.ReadLine().Split();

                string bookTitle = inputedInfo[0];
                string bookAuthor = inputedInfo[1];
                string bookPublisher = inputedInfo[2];
                string bookRelese = inputedInfo[3];
                string bookISBN = inputedInfo[4];
                double BookPrice = double.Parse(inputedInfo[5]);

                Book book = new Book(bookTitle, bookAuthor, bookPublisher, bookRelese, bookISBN, BookPrice);

                libraries.Books.Add(book);
            }

            var result = new Dictionary<string, double>();

            foreach (Book bookData in libraries.Books)
            {
                if (!result.ContainsKey(bookData.author))
                {
                    result.Add(bookData.author, 0.0);
                }

                result[bookData.author] += bookData.price;
            }

            foreach (var item in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
            }
            
        }
    }

    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string releaseDate { get; set; }
        public string ISBN { get; set; }
        public double price { get; set; }

        public Book(string title, string author, string publisher, string releaseDate, string ISBN, double price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.ISBN = ISBN;
            this.price = price;
        }
        
    }

    class Library
    {
        string name { get; set; }
        public List<Book> Books = new List<Book>();
    }
}
