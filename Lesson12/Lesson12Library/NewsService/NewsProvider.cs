using Lesson12Library.NewsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library
{
    public class NewsProvider
    {
        public event EventHandler<NewsEventArgs> SendNews;
        public NewsProvider()
        {

        }
        public void SendNewsToClient(NewsEventArgs e)
        {
            SendNews?.Invoke(this, e);
        }
        public void SendNewsToProvider(object o, NewsEventArgs e)
        {
            SendNewsToClient(e);
        }
    }
}
