using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    AudioSource hitsound;
    public int currentHealth;
    public HealthBar healthbar;
    public GameObject player;
    public GameObject deathEffect;
    Collider2D other;

    void Start()
    {
        hitsound = GetComponent<AudioSource>();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void update()
    {
        if(other.gameObject.CompareTag("PLayer")){
			Destroy (gameObject);
		}
    }

    public void TakeDamage (int damage)
    {
        hitsound.Play();
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        if(currentHealth <= damage)
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
