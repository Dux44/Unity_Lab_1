using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripst.OOP.Interfaces
{
    interface IDamageble
    {
        Vector3 Position { get; }
        public void Damage(float damage);
    }
}
