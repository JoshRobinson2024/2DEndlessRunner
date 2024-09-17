using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Much like the Start() and Update() methods, OnTriggerEnter2D is a special unity method that is called
    // by unity automatically at a specific point - in this case whn something enters the trigger attached
    // to this gameobject.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the gameobject that has collided with our rigger is tagged with "CleanUp"...
        if (collision.gameObject.tag == "CleanUp")
        {
            // Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
}
