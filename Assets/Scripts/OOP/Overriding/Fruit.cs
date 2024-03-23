using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripst.OOP.Overriding
{
    class Fruit
    {
        public Fruit()
        {
            Debug.Log("1st Fruit Constructor called");
        }
        public virtual void Chop()
        {
            Debug.Log("The fruit has been chopped.");
        }
        public virtual void SayHello()
        {
            Debug.Log("Hello, I am a fruit");
        }
    }
}
