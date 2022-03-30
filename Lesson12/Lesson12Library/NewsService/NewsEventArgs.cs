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
        public NewsEventArgs(News news)
        {
            this.news = news;
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
