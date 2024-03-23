using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripst.OOP.Inharitance
{
    public class Fruit
    {
        public string color;

        public Fruit()
        {
            color = "Orange";
            Debug.Log("1st Fruit Constructor called");
        }
        public Fruit(string color)
        {
            this.color = color;
            Debug.Log("2st Fruit Constructor called");
        }
        public void Chop()
        {
            Debug.Log("The" + color + "fruit has been chopped.");
        }
        public void SayHello()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }
}
