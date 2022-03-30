using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library
{
    public class News
    {
        private string NewsTitle { get; }
        private string Category { get; }
        private string Text { get; }
        public News(string category, string newsTitle, string text)
        {
            NewsTitle = newsTitle;
            Category = category;
            Text = text;
        }
        public string GetNewsCategory ()
        {
            return Category;
        }
        public override string ToString()
        {
            return $"Катагория: {Category} \nЗаголовок: {NewsTitle} \n{Text}";
        }
    }
}
