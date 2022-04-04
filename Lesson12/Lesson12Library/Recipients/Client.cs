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
        private List<News> News { get; set; } = new List<News>();
        private List<string> BlackList = new List<string>();
        private NewsCategories Categories { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public void AddNewsCategories (NewsProvider newsProvider, NewsCategories newsCategories)
        {
            newsProvider.AddToNewsletter(this, newsCategories);
            Categories |= newsCategories;
        }
        public void RemoveNewsCategories(NewsProvider newsProvider, NewsCategories newsCategories)
        {
            newsProvider.RemoveFromNewsletter(this, newsCategories);
            Categories ^= newsCategories;
        }
        public NewsCategories GetClientsCategories()
        {
            return Categories;
        }
        private void AddNewsToClient (NewsEventArgs e)
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
            if (!BlackList.Contains(e.GetNewsPortalName()))
            {
                    AddNewsToClient(e);
            }            
        }
    }
}
