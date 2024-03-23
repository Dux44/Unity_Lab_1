using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Generics;

public class GenericClassExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();
        myClass.UpdateItem(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
