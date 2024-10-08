using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // check if the object colliding with the coin is the player
        if (other.gameObject.CompareTag("Coin"))
        {

            coinCount += 100;
            coinText.text = "Score:" + coinCount.ToString();
        }
    }
}
