using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library
{
    public class NewsProvider
    {
        public event Action<News> SendNews;        
        public NewsProvider()
        {
        }
        public void SendNewsToClient(News news)
        {
            SendNews?.Invoke(news);
        }
    }
}
