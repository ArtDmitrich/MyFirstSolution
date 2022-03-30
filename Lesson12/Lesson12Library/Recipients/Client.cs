using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddNewsToClient (News news)
        {
            News.Add(news);
        }
        public void CheckNews(News news)
        {
            foreach (var item in ClietsCategory)
            {
                if (news.GetNewsCategory().ToUpper() == item.ToUpper())
                {
                    AddNewsToClient(news);
                }
            }
        }
    }
}
