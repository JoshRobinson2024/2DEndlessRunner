using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TheControls : MonoBehaviour
{
    Animator anim;
    public AudioClip jump;
    public AudioClip backgroundmusic;
    
    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;

    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sfxPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Constant Forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);  

        // jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
        anim.SetBool("IsGrounded", isGrounded);
    }

    private void Jump()
    {
        // Add an upward force for jumping 
        sfxPlayer.PlayOneShot(jump);
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
    
}
