using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripst.OOP.Overriding
{
    class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("1st Apple constructor called");
        }
        public override void Chop()
        {
            base.Chop();
            Debug.Log("The apple has been chopped.");
        }
        public override void SayHello()
        {
            base.SayHello();
            Debug.Log("Hello im an apple.");
        }
    }
}
