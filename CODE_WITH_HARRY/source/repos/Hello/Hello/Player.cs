using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string name = "man";
        private int health = 79;

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int h) { 
            health = h;
        }
    }
}
