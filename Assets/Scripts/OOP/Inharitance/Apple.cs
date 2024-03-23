using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripst.OOP.Inharitance
{
    class Apple:Fruit
    {
        public Apple()
        {
            color = "red";
            Debug.Log("1st Apple Constructor");
        }
        public Apple(string color) : base(color)
        {
            Debug.Log("2nd Apple Constructor called");
        }
    }
}
