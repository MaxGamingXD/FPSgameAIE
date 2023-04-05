using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile1 : MonoBehaviour
{
    public float damage = 10;

    public float projectileLife = 5;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= projectileLife)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Enemy"))
        {
          //  Debug.Log("player hit");
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject);
        }
        else
        {
         //   Debug.Log("self destruct");
            Debug.Log(collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}
