using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.tag == "Coins")
            {
                Debug.Log("AAAH");
                GameObject.Find("ScoreManager").GetComponent<ScoreManager>().ChangeScore(coinValue);
            }
        }

        //THIS DESTROYS THE COINS
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }

    }
}


