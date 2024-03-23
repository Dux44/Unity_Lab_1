using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripst.OOP.Interfaces;

public class Explosion : MonoBehaviour
{
    public float range = 10f;
    public float damage = 35f;
    List<IDamageble> m_AllDamageables = new List<IDamageble>();
    // Start is called before the first frame update
    void Start()
    {
        MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
        for (int i = 0; i < allScripts.Length; i++)
        {
            if(allScripts[i] is IDamageble)
            {
                m_AllDamageables.Add(allScripts[i] as IDamageble);
            }
        }

    }
    public void Explode()
    {
        for (int i = 0; i < m_AllDamageables.Count; i++)
        {
            if(Vector3.Distance(m_AllDamageables[i].Position,transform.position) < range)
            {
                m_AllDamageables[i].Damage(damage);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
