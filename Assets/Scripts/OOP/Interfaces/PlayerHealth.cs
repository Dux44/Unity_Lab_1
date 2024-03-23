using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Interfaces;

public class PlayerHealth : MonoBehaviour, IDamageble
{
    public float startingHeals = 100f;
    float m_CurrentHeals;

    Vector3 IDamageble.Position 
    {
        get { return transform.position; }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_CurrentHeals = startingHeals;
    }
     public void Damage(float damage)
    {
        m_CurrentHeals -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
