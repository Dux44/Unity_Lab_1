using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripst.OOP.Member_Hiding
{
    public class Enemy : Humanoid
    {
        new public void Yell()
        {
            Debug.Log("Enemy version of the Yell() method");
        }
    }
}
