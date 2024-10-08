using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShardCollection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // check if the object colliding with the coin is the player
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
