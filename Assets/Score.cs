using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Score:" + coinCount.ToString();
    }
}
