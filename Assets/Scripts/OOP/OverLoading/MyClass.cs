using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripst.OOP.OverLoading
{
    class MyClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
