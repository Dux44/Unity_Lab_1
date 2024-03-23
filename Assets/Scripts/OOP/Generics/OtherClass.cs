using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Generics;

public class OtherClass : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SomeOtherClass myClass = new SomeOtherClass();
        myClass.GenericMethod<int>(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
