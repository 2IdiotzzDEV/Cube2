using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coincollect : MonoBehaviour
{
    public int score;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            score = score + 1;
            Destroy (other.gameObject);
            
        }
    }
}