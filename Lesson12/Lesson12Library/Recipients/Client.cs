using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson12Library.NewsService;
using Lesson12Library.Enums;

namespace Lesson12Library
{
    public class Client
    {
        public string Name { get; }
        public List<News> News { get; set; } = new List<News>();
        private List<string> BlackList = new List<string>();
        public NewsCategories Categories { get; set; }
        public Client(string name, NewsProvider provider)
        {
            Name = name;
            provider.SendNews += CheckNews;
        }
        public void AddNewsToClient (NewsEventArgs e)
        {
            News.Add(e.News);
        }
        public void AddInBlackList(string name)
        {
            BlackList.Add(name);
        }
        public void RemoveFromBlackList(string name)
        {
            if (BlackList.Contains(name))
            {
                BlackList.Remove(name);
            }
        }
        public void ClearBlackList()
        {
            BlackList.Clear();
        }
        public void CheckNews(object o, NewsEventArgs e)
        {                            
            if (Categories.HasFlag(e.News.GetNewsCategory()) && !BlackList.Contains(e.GetNewsPortalName()))
            {
                    AddNewsToClient(e);
            }            
        }
    }
}
