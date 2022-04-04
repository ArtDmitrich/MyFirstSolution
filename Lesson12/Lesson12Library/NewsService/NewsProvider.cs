using Lesson12Library.NewsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson12Library.Enums;

namespace Lesson12Library
{
    public class NewsProvider
    {
        public event EventHandler<NewsEventArgs> SendNews;
        public event EventHandler<NewsEventArgs> SendEvents;
        public event EventHandler<NewsEventArgs> SendSport;       
        public event EventHandler<NewsEventArgs> SendWeather;
        public event EventHandler<NewsEventArgs> SendHumor;


        private List<string> BlackList = new List<string>();
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
        private void SendNewsToClient(NewsEventArgs e)
        {
            switch(e.News.GetNewsCategory())
            {
                case NewsCategories.News:
                    SendNews?.Invoke(this, e);
                    break;
                case NewsCategories.Events:
                    SendEvents?.Invoke(this, e);
                    break;
                case NewsCategories.Sport:
                    SendSport?.Invoke(this, e);
                    break;
                case NewsCategories.Weather:
                    SendWeather?.Invoke(this, e);
                    break;
                case NewsCategories.Humor:
                    SendHumor?.Invoke(this, e);
                    break;
            }          
        }
        internal void SubscribeToNewsletter (Client client, NewsCategories newsCategories)
        {
            switch (newsCategories)
            {
                case NewsCategories.News:
                    SendNews += client.CheckNews;
                    break;
                case NewsCategories.Events:
                    SendEvents += client.CheckNews;
                    break;
                case NewsCategories.Sport:
                    SendSport += client.CheckNews;
                    break;
                case NewsCategories.Weather:
                    SendWeather += client.CheckNews;
                    break;
                case NewsCategories.Humor:
                    SendHumor += client.CheckNews;
                    break;
            }
        }
        internal void UnsubscribeFromNewsletter(Client client, NewsCategories newsCategories)
        {
            switch (newsCategories)
            {
                case NewsCategories.News:
                    SendNews -= client.CheckNews;
                    break;
                case NewsCategories.Events:
                    SendEvents -= client.CheckNews;
                    break;
                case NewsCategories.Sport:
                    SendSport -= client.CheckNews;
                    break;
                case NewsCategories.Weather:
                    SendWeather -= client.CheckNews;
                    break;
                case NewsCategories.Humor:
                    SendHumor -= client.CheckNews;
                    break;
            }
        }
        internal void SendNewsToProvider(object o, NewsEventArgs e)
        {
            if (!BlackList.Contains(e.GetNewsPortalName()))
            {
                SendNewsToClient(e);
            }
        }
    }
}
