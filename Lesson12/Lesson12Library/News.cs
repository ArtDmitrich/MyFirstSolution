using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library
{
    public class News
    {
        public string NewsTitle { get; }
        public string Category { get; }
        public string Text { get; }
        public News(string category, string newsTitle, string text)
        {
            NewsTitle = newsTitle;
            Category = category;
            Text = text;
        }
        public override string ToString()
        {
            return $"Катагория: {Category} \nЗаголовок: {NewsTitle} \n{Text}";
        }
    }
}
