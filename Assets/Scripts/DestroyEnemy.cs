using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public ParticleSystem EnemyDeath;
    public GameObject EnemyDestroyEffect;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "KillEnemy")
        {
            CreateEnemyDeath();
            
            Destroy (gameObject, 0.12f);
        }
    }

    void CreateEnemyDeath()
    {
        EnemyDeath.Play();
    }
}
