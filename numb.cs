using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    internal class numb
    {
        int z;
        Random x = new Random();
        public numb() { }
        public int randomnumber(int y)
        {
            z = x.Next(1, y);
            return z;
        }
    }
}
