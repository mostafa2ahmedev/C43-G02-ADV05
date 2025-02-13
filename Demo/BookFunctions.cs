using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region Part 01;
    internal class BookFunctions
    {

        public static string GetTitle(Book B)
        {
            return B?.Title ?? "No Name";

        }
        public static string GetAuthors(Book B)
        {

            string authors = "";

            foreach (var author in B.Authors)
            {
                authors += author + ",";
            }


            return authors ?? "No Authors";

        }
        public static string GetPrice(Book B)
        {

            return B?.Price.ToString() ?? "No Price";

        }
    } 
    #endregion
}
