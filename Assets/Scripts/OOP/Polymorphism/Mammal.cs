using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mammal
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    public class Mammal
    {
        public void GrowFurr() { }
    }
    public class Cat:Mammal
    {
        public void Meow() { }
    }
    public class Dog : Mammal
    {
        public void Woof() { }
    }
    public class RescueShelter
    {
        public Mammal[] mammals = new Mammal[3];
        public RescueShelter()
        {
            mammals[0] = new Cat();
            mammals[1] = new Dog();
            Cat cat1 = mammals[0] as Cat;
            cat1.Meow();
            Dog dog1 = (Dog)mammals[1];
            dog1.GrowFurr();
            dog1.Woof();
            if(mammals[0] is Cat)
            {
                Cat cat2 = mammals[0] as Cat;
                cat2.GrowFurr();
            }
            if (mammals[1] is Dog)
            {
                Dog dog2 = (Dog)mammals[0];
                dog2.Woof();
            }
        }
    }
}

