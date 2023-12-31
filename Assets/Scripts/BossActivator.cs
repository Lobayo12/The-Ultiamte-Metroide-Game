using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivator : MonoBehaviour
{
    public GameObject bossToActivate;

    public string bossRef;

    // Looks if the player is close enough of the boss to start the combact
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (PlayerPrefs.HasKey(bossRef))
            {
                if(PlayerPrefs.GetInt(bossRef) != 1)
                {
                    bossToActivate.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
            else
            {
                bossToActivate.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
