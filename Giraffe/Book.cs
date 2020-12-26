using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Book
    {
        // class attributes 
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
