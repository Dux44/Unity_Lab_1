using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripst.OOP.Generics
{
    public class GenericClass <T>
    {
        T item;
        public void UpdateItem(T newItem)
        {
            item = newItem;
        }
    }
}
