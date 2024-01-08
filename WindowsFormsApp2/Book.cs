using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Book
    {
        private Boolean isBorrowed;
        private string title;
        private string author;
        private string genre;

        public Book(string title, string author, string genre, Boolean isBorrowed)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.IsBorrowed = isBorrowed;
        }

        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }

        override public string ToString()
        {
            return $"\"{Title}\" av {Author}. ({Genre})";
        }
    }


}
