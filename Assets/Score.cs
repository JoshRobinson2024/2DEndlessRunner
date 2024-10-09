using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static public int coinCount;
    public TMP_Text coinText;
    public bool endMenu;
    public bool startMenu;
    void OnTriggerEnter2D(Collider2D other)
    {
        // check if the object colliding with the coin is the player
        if (other.gameObject.CompareTag("Coin"))
        {

            coinCount += 100;
            coinText.text = "Score:" + coinCount.ToString();
        }

        else if (other.gameObject.CompareTag("Blue")){

            coinCount -= 50;
            coinText.text = "Score:" + coinCount.ToString();
            
        }
        }
    
    private void Start()
    {
        if (endMenu)
        {
            coinText.text = "Score:" + coinCount.ToString();
        }
        if (startMenu)
        {
            coinCount = 0;
        }
    }
    public void resetScore()
    {
        coinCount = 0;
    }
    
        
    
}
