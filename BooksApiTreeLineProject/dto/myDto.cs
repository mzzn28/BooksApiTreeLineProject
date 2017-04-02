using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BooksApiTreeLineProject.Models;

namespace BooksApiTreeLineProject.dto
{
    public class myDto
    {

        //Data of books hard coded
        Book book1 = new Book
        {
            title = "On this day in Detroit history",
            author = "Loomis, Bill",
            isbn = "9781626198333",
            price = 25.56,
            ifebook = false
        };
        Book book2 = new Book
        {
            title = "OCA Java SE 8 programmer study guide",
            author = "Kurniawan, Budi",
            isbn = "9781771970228",
            price = 65.46,
            ifebook = true
        };
        Book book3 = new Book
        {
            title = "Java 8 lambdas ",
            author = "	Warburton, Richard ",
            isbn = "6789065432010",
            price = 14.59,
            ifebook = true
        };
        Book book4 = new Book
        {
            title = "Tremendous technology inventions",
            author = "	Marsico, Katie ",
            isbn = "5678909012345",
            price = 125.36,
            ifebook = true
        };
        Book book5 = new Book
        {
            title = "Hama Yaran Dozukh",
            author = "A K Sager",
            isbn = "786443213456",
            price = 5.26,
            ifebook = true
        };
        
        List<Book> bookslistA = new List<Book>();

        public List<Book> makedata() {
            bookslistA.Add(book1);
            bookslistA.Add(book2);
            bookslistA.Add(book3);
            bookslistA.Add(book4);
            bookslistA.Add(book5);

            return bookslistA;
        }


      }
}