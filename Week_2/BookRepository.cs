using System.Collections.Generic;

namespace Week_2
{
    public class BookRepository {

        public IEnumerable<Book> GetBooks() {
            return new List<Book>()

            { 
                new Book() {Title="ADO.Net Step by Step",Price=5},
                new Book() {Title="ASP.Net MVC",Price=9.9f},
                new Book() {Title="ASP.Net Wep API",Price=6},
                new Book() {Title="C# Advanced Topic",Price=12},
                new Book() {Title="C# Advanced Topic",Price=10},
                new Book() {Title="Abc",Price=8},
            };
        }

    }
}
