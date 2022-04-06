using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13Library
{
    public struct Product
    {
        public string Name { get; set; }
        public string ShopName { get; set; }
        public Product(string name, string shopName)
        {
            Name = name;
            ShopName = shopName;
        }
        public override string ToString()
        {
            return $"продукт: {Name}  магазин:{ShopName}";
        }
    }
}