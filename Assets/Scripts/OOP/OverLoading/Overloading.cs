using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.OverLoading;
public class Overloading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();
        myClass.Add(1, 3);
        myClass.Add("some", "text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
