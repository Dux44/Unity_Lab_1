using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripst.OOP.Generics
{
    class SomeOtherClass
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }
}
