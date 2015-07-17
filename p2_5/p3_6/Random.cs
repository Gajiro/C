using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_6
{
    class Random
    {
        System.Random rand = new System.Random();
        //public int r ;

        public int getRandom()
        {
            int r = 0;
            r = rand.Next(1, 7);
            return r ;
        }
    }
}
