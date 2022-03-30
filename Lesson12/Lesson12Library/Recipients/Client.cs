using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson12Library.NewsService;

namespace Lesson12Library
{
    public class Client
    {
        public string Name { get; }
        public List<News> News { get; set; } = new List<News>();
        public List<string> ClietsCategory { get; set; } = new List<string>();
        public Client(string name, NewsProvider provider)
        {
            Name = name;
            provider.SendNews += CheckNews;
        }
        public void AddNewsToClient (NewsEventArgs e)
        {
            News.Add(e.News);
        }
        public void CheckNews(object o, NewsEventArgs e)
        {
            foreach (var item in ClietsCategory)
            {
                if (e.News.GetNewsCategory().ToUpper() == item.ToUpper())
                {
                    AddNewsToClient(e);
                }
            }
        }
    }
}
