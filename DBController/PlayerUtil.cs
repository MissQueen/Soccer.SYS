using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.SYS.DBController
{
    class PlayerUtil
    {
        public int playercount { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public PlayerUtil()
        {
        }
        public PlayerUtil(int playercount,double x,double y)
        {
            this.playercount = playercount;
            this.x = x;
            this.y = y;
        }
    }
}
