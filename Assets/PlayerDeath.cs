using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Score SC;
    public float fallThreshold = -10f;
    public AudioSource sfxPlayer;
    void Start()
    {
        sfxPlayer = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadSceneAsync(3);
            
        }
    }

    public void Soundplay()
    {

        if (transform.position.y < fallThreshold)
        {
            sfxPlayer.Play();
            SceneManager.LoadSceneAsync(3);
        }
    }
}
