using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int damageAmount = 1;

    public bool destroyOnDamage;
    public GameObject destroyEffect;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            DealDamage();
        }
    }

    // Calls the function to make damage when recived a damag
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            DealDamage();
        }
    }


    // Takes care of dealing damag to the player
    void DealDamage()
    {
        PlayerHealthController.instance.DamagePlayer(damageAmount);

        if(destroyOnDamage)
        {
            if (destroyEffect != null)
            {
                Instantiate(destroyEffect, transform.position, transform.rotation);
            }

            Destroy(gameObject);
        }
    }
}
