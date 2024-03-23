using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetsShop : MonoBehaviour
{
    [SerializeReference]
    public Mammal.Mammal mammal = new Dolphin();
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
public class Animal { }

public class Dolphin : Mammal.Mammal { }

