using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MinusScore : MonoBehaviour
{
    public StarShardCollection ssc;
    static public int coinCount;
    public TMP_Text coinText;
    public bool endMenu;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        // check if the object colliding with the coin is the player
        
    }
    private void Start()
    {
        if (endMenu)
        {
            coinText.text = "Score:" + coinCount.ToString();
        }
    }
}
