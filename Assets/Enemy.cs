using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    AudioSource hitsound;

    public GameObject deathEffect;

    void Start()
    {
        hitsound = GetComponent<AudioSource>();
    }

    public void TakeDamage (int damage)
    {
        hitsound.Play();
        health -= damage;
        if(health <= damage)
        {
            Die();
        }
    }

    public void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
