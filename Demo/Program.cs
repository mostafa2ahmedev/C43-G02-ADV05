using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = [
                new Book("2222", "C#", ["Mostafa","Ayman"],DateTime.Now,100),
                new Book("1111", "C++", ["Mostafa","Ayman"],DateTime.Now,200),
                new Book("3333", "C", ["Mostafa","Ayman"],DateTime.Now,300),
                new Book("4444", "Java", ["Mostafa","Ayman"],DateTime.Now,400),
            ];
            #region a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class. 
            //BookDelegate fPtr = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(books, fPtr);

            #endregion
            #region b) Use the Proper build in delegate. 
            //Func<Book, string> fPtr = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(books, fPtr);


            #endregion
            #region c) Anonymous Method (GetISBN). 
            //LibraryEngine.ProcessBooks(books,delegate (Book b) { return b?.ISBN??"No Name"; });

            #endregion
            #region d) Lambda Expression (GetPublicationDate). 
            //LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToString());

            #endregion
        }
    }
}
