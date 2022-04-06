using Lesson13Library;

var products = new Product[5]
{
    new Product("meat", "бвва"),
    new Product("milk", "абвг"),
    new Product("drink", "аадг"),
    new Product("drink", "ааа"),
    new Product("meat", "гда")

};
Console.WriteLine("Массив до сортировки");
products.PrintArrayOfProductOnConsole();
products = products.SortArrayOfProductByShopName();

Console.WriteLine("Массив после сортировки");
products.PrintArrayOfProductOnConsole();

Console.WriteLine("поиск всех продуктов конкретного магазина");
var findedProducts = products.FindAllProductInShop();

if (findedProducts != null)
{
    findedProducts.PrintArrayOfProductOnConsole();
}
Console.ReadKey();