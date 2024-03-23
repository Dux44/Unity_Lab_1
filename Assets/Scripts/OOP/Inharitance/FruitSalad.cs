using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Inharitance;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();
        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Create the apple");
        myApple = new Apple("red");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
