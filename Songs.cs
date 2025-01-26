using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    internal class Songs
    {
        public string Title { get; set; }
        public int ClickCount { get; set; }

        public Songs() { }
        public Songs(string title)
        {
            Title = title;
            ClickCount = 0;
        }    
    
    }
}
