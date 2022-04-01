using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson12Library.Enums;

namespace Lesson12Library
{
    public class News
    {
        private string NewsTitle { get; }
        private NewsCategories Category { get; }
        private string Text { get; }
        public News(NewsCategories category, string newsTitle, string text)
        {
            NewsTitle = newsTitle;
            Category = category;
            Text = text;
        }
        public NewsCategories GetNewsCategory ()
        {
            return Category;
        }
        public override string ToString()
        {
            return $"Катагория: {Category} \nЗаголовок: {NewsTitle} \n{Text}";
        }
    }
}
