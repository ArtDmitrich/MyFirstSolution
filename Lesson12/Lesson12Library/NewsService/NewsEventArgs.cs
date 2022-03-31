using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library.NewsService
{
    public class NewsEventArgs: EventArgs
    {
        private News news;
        private string newsPortalName;
        public NewsEventArgs(News news, string newsPortalName)
        {
            this.news = news;
            this.newsPortalName = newsPortalName;
        }
        public string GetNewsPortalName()
        {
            return newsPortalName;
        }
        public News News
        {
            get 
            {
                return this.news;
            }            
        }
    }
}
