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
        public void SendNewsToClient(NewsEventArgs e)
        {
            SendNews?.Invoke(this, e);
        }
        public void SendNewsToProvider(object o, NewsEventArgs e)
        {
            if (!BlackList.Contains(e.GetNewsPortalName()))
            {
                SendNewsToClient(e);
            }
        }
    }
}
