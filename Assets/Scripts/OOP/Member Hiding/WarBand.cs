using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Member_Hiding;


public class WarBand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
