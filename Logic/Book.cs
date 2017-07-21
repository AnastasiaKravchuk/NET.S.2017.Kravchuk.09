using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Book:  IComparable<Book> , IEquatable<Book>
    {
        private string title;
        private string author;
        private string genre;
        private int libraryChiper;
        private string publisher;
        private int publishYear;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The title of the book hasn't been entered!");
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The author of the book hasn't been entered!");
                author = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The genre of the book hasn't been entered!");
                genre = value;
            }
        }

        public int LibraryChiper
        {
            get
            {
                return libraryChiper;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Number equal or less then zero has been entered!");
                if (value.ToString().Length != 6)
                    throw new ArgumentException("Library chiper consists of 6 digits!");
                libraryChiper = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The publisher of the book hasn't been entered!");
               publisher = value;
            }
        }

        public int PublishYear
        {
            get
            {
                return publishYear;
            }
            set
            {
                if (value > 2017 && value < 1500)
                    throw new ArgumentException("The publishing date of the book has been entered incorrectly!");
                publishYear = value;
            }
        }

        public Book(string titleInput, string authorInput, string genreInput, int chipherInput, string publisherInput, int dataInput)
        {
            title = titleInput;
            author = authorInput;
            genre = genreInput;
            libraryChiper = chipherInput;
            publisher = publisherInput;
            publishYear = dataInput;
        }


        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + title.GetHashCode();
            hash = hash * 23 + author.GetHashCode();
            hash = hash * 23 + genre.GetHashCode();
            hash = hash * 23 + libraryChiper.GetHashCode();
            hash = hash * 23 + publisher.GetHashCode();
            hash = hash * 23 + publishYear.GetHashCode();
            return hash;
        }

        public bool Equals(Book obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (obj == null)
                return false;
            if (this.libraryChiper == obj.libraryChiper)
                return true;
            return false;
        }

        public int CompareTo(Book obj)
        {
            if (obj == null)
                return 1;
            if (this.libraryChiper > obj.libraryChiper)
                return 1;
            return 0;
        }

        public override string ToString()
        {
            String str = " Title: " + title + "\n" +
                    " Author" + author + "\n" +
                    " Genre: " + genre + "\n" +
                    " Library chiper(?): " + libraryChiper + "\n" +
                    " Publisher: " + publisher + "\n" +
                    " Publishing year" + publishYear + "\n";
            return str;
        }
    }
}
