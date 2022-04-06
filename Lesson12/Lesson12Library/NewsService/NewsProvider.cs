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
        private event EventHandler<NewsEventArgs> SendNews;
        private event EventHandler<NewsEventArgs> SendEvents;
        private event EventHandler<NewsEventArgs> SendSport;       
        private event EventHandler<NewsEventArgs> SendWeather;
        private event EventHandler<NewsEventArgs> SendHumor;
        //не совсем нравится эта модель. сам понимаю, что при добавлении новой категории,
        //нужно будет не только enum изменить, но и в этом файле добавить событие и 3 блока case в методах
        
        //не нашел причину почему подписка и отписка от события работает только через switch
        //закомменченые строки в методах не работают
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
            var myEvent = GetEventHandler(e.News.GetNewsCategory());
            myEvent?.Invoke(this, e);
        }
        internal void AddToNewsletter(Client client, NewsCategories newsCategories)
        {
            //var myEvent = GetEventHandler(newsCategories);
            //myEvent += client.CheckNews;
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
        internal void RemoveFromNewsletter(Client client, NewsCategories newsCategories)
        {
            //var myEvent = GetEventHandler(newsCategories);
            //myEvent -= client.CheckNews;
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
        private EventHandler<NewsEventArgs> GetEventHandler(NewsCategories newsCategories)
        {
            switch (newsCategories)
            {
                case NewsCategories.News:
                    return SendNews;
                    break;
                case NewsCategories.Events:
                    return SendEvents;
                    break;
                case NewsCategories.Sport:
                    return SendSport;
                    break;
                case NewsCategories.Weather:
                    return SendWeather;
                    break;
                case NewsCategories.Humor:
                    return SendHumor;
                    break;
            }

            return null;
        }
    }
}
