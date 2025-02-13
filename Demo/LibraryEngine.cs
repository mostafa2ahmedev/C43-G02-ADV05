using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // User Defined Delegate
    public delegate string BookDelegate( Book b);


    internal static class LibraryEngine
    {
        #region a) Create User Defined Delegate with the same signature of methods  existed in Bookfunctions class. 
        //public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
        //{
        //    foreach (Book book in bList)
        //       Console.WriteLine(fPtr.Invoke(book));
            
        //}
        #endregion

        #region b) Use the Proper build in delegate. 
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {

            foreach (Book book in bList)
                Console.WriteLine(fPtr.Invoke(book));


        }

        #endregion


    }
}
