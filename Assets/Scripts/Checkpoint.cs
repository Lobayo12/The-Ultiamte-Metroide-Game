using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Takes care of making checkpoint where to respawwn
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            RespawnController.instance.SetSpawn(transform.position);
        }
    }
}
