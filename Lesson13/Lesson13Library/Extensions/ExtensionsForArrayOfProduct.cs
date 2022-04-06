using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson13Library.Exception;

namespace Lesson13Library
{
    public static class ExtensionsForArrayOfProduct
    {
        public static void PrintArrayOfProductOnConsole(this Product[] products)
        {
            foreach(var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public static Product[] SortArrayOfProductByShopName(this Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                for (int j = i + 1; j < products.Length; j++)
                {                    
                    if (CheckTheExchange(products[i].ShopName, products[j].ShopName))
                    {
                        var temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }

            return products;
        }
        private static bool CheckTheExchange (string s1, string s2)
        {
            var length = s1.Length > s2.Length ? s2.Length : s1.Length;

            for (int i = 0; i < length ; i++)
            {                
                if (s1[i] > s2[i])
                {
                    return true;
                }
                else if (s1[i] == s2[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
        public static Product[] FindAllProductInShop (this Product[] products)
        {
            Console.WriteLine("Введите название магазина");
            var shopName = Console.ReadLine();
            var productsFromShop = new List<Product>();

            try
            {
                foreach (var item in products)
                {
                    if (item.ShopName.Contains(shopName))
                    {
                        productsFromShop.Add(item);
                    }
                }

                if (productsFromShop.Count == 0)
                {
                    throw new MyException(shopName);
                }

                Console.WriteLine();

                return productsFromShop.ToArray();
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
