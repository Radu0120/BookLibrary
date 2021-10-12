using System;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get;set;}
        public string Author { get;set;}
        public int PageNumber { get;set;}
        public string ISBN13 { get;set;}

        public Book()
        {

        }
        public Book(string title, string author, int pagenumber, string isbn)
        {
            Title = title;
            Author = author;
            PageNumber = pagenumber;
            ISBN13 = isbn;
        }
    }
}
