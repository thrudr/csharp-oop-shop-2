using CSharp_Shop_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Oop_Shop2
{
    public class Shop
    {
        // ATTRIBUTES

        private string shopName;
        private string address;
        private int houseNumber;
        private string citty;
        private List<Article> articles;

        // CONSTRUCTORS

        public Shop(string shopName, string address, int houseNumber, string citty)
        {
            this.shopName = shopName;
            this.address = address;
            this.houseNumber = houseNumber;
            this.citty = citty;
            this.articles = new List<Article>();
        }

        // GETTERS

        public string GetShopName() {  return shopName;  }
        public string GetAddress() {  return address;  }
        public int GetHouseNumber() {  return houseNumber;  }
        public string GetCitty() {  return citty; }
        public List<Article> GetListProducts() { return articles; }

        // SETTERS

        public void SetAddress(string address) { this.address = address; }
        public void SetHouseNumber(int houseNUmber) { this.houseNumber = houseNUmber; }
        public void SetCitty(string citty) { this.citty = citty; }

        // METHODS

        public void printShopDate()
        {
            Console.WriteLine("--------------" + this.shopName + "---------------");
            Console.WriteLine(address);
            Console.WriteLine(houseNumber);
            Console.WriteLine(citty);
        }

        public void addArticle(Article article)
        {
            this.articles.Add(article); 
        }
    }
}
