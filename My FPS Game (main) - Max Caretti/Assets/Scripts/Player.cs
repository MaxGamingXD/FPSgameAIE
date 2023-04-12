using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("EnemyBullet"))
            {
                currentHealth -= collision.gameObject.GetComponent<HandleProjectile>().damage;
                if (currentHealth <= 0)
                {
                    TargetDestroy();
                }
            }
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    private void TargetDestroy()
    {
        gameObject.SetActive(false);
    }
}
