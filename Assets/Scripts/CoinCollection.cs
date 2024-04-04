using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    private int coin = 0;
    public AudioSource collectCoin;
    public Text scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {
            coin++;
            collectCoin.Play();
            Destroy(other.gameObject);
        }
        scoreText.text = "Score: " + coin.ToString();
    }
}
