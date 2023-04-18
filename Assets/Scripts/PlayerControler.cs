using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
     int playerHealt = 3;
    public float playerSpeed = 5.5f;
    public float jumpforce = 3f;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rBody;
    private GroundSensor sensor;
    public Animator anim;
    float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent <SpriteRenderer>();
        rBody = GetComponent <Rigidbody2D>();
        anim = GetComponent<Animator>();
        sensor = GameObject.Find("GroundSensor").GetComponent <GroundSensor>();
        playerHealt = 10;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(horizontal < 0)
        {
            spriteRenderer.flipX = true;
            //anim.SetBool("IsRunning", true);
        }
        else if(horizontal > 0)
        {
            spriteRenderer.flipX = false;
            //anim.SetBool("IsRunning", true);
        }
        else
        //anim.SetBool("IsRunning", false);
        if (Input.GetButtonDown("Jump") && sensor.isGrounded)
        {
            rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            //anim.SetBool("IsJumping", true);
        }
    }
}
