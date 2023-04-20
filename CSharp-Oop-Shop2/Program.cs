
using CSharp_Oop_Shop2;
using CSharp_Shop_2;

Console.WriteLine("OOP Shop");

/*test
Article shop1 = new Article("Nome", "description", 25.50f, 22);
shop1.printArticle();
*/

Article article_1 = new Article("Candele", "Colorate - Non profumate - Set con 9 candele", 10.00f, 22);
article_1.printArticle();

Article article_2 = new Article("Libro - Nel Giardino della Strega Verde", "Arin Murphy-Hiscock", 15.00f, 22);
article_2.printArticle();

Article article_3 = new Article("Punte Naturali di Ametista", "Laser grezzo proveniente del Brasile", 15.00f, 22);
article_3.printArticle();

article_1.SetDescription("nuova descrizione");
string descrizione = article_1.GetDescription();

Shop shop = new Shop("test ", "sssss", 12, "Latina");
shop.addArticle(article_1);
shop.addArticle(article_2);
shop.addArticle(article_3);

Console.WriteLine(descrizione);