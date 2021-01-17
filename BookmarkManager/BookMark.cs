using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BookmarkManager
{
    public class BookMark
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public void OpenStite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);
        }
    }
}
