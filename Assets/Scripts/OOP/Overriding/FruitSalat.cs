using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Overriding;

public class FruitSalat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple myApple = new Apple();

        myApple.SayHello();
        myApple.Chop();

        Fruit fruit = new Apple();
        {
            fruit.Chop();
            fruit.SayHello();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
