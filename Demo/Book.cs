using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region Part 01: 
    internal class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string _ISBN, string _title, string[] _authors, DateTime _publicationDate, decimal _price)
        {
            this.Authors = _authors;
            this.Title = _title;
            this.PublicationDate = _publicationDate;
            this.Price = _price;
            this.ISBN = _ISBN;
        }


        public override string ToString()
        {
            string authors = "";

            foreach (var author in Authors)
            {
                authors += author + ",";
            }

            return $"ISBN : {ISBN}, Title : {Title}, Authors : {Authors}, PublicationDate : {PublicationDate}, Price : {Price}";
        }
    } 
    #endregion
}
