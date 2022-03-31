using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library.NewsService
{
    public class NewsPortal
    {
        private string Name { get; }
        private List<News> News { get; set; } = new List<News>();
        public event EventHandler<NewsEventArgs> SendNews;
        public NewsPortal(string name, NewsProvider provider)
        {
            Name = name;
            SendNews += provider.SendNewsToProvider;
        }

        public void AddNewsInPortal (News news)
        {
            News.Add(news);

            var e = new NewsEventArgs(news, this.Name);
            SendNews?.Invoke(this, e);
        }
    }
}
