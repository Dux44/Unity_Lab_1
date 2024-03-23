using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripst.OOP.Static
{
    public class Enemy
    {
        public static int enemyCount = 0;
        public Enemy()
        {
            enemyCount++;
        }
    }
}
