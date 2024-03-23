using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Game : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            Player player = new Player();
            player.Experience = 5;
            int x = player.Experience;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    public class Player
    {
        private int exp;
        public int Experience
        {
            get { return exp; }
            set { exp = value; }
        }
        public int Level
        {
            get { return exp / 1000; }
            set { exp = value / 1000; }
        }
        public int Health { get; set; }
    }
}

