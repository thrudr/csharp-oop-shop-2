using CSharp_Shop_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Oop_Shop2
{
    public class Book : Article
    {
        //ATTRIBUTES
        private string author;
        private string ibns;

        //CONSTRUCTOR
        public Book(string name, string description, float price, int iva, string author, string ibns) : base(name, description, price, iva);

        //GETTERS
        public string GetAuthor() { return this.author; }

        public string GetIbns() { return this.ibns; }

        //METHODS

    }
}
