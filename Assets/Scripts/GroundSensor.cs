using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private PlayerControler controller;
    public bool isGrounded;
    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponentInParent<PlayerControler>();
    }

     void OnTriggerEnter2D(Collider2D other)
   {
    if (other.gameObject.layer == 3)
    {
    isGrounded = true;
    //controller.anim.SetBool("IsJumping" , false);
    }
   }

   void OnTriggerStay2D(Collider2D other)
   {
    if(other.gameObject.layer == 3)
    {
      isGrounded = true;
      //controller.anim.SetBool("IsJumping" , false);
    }
   }

    void OnTriggerExit2D(Collider2D other)
   {
    if (other.gameObject.layer == 3)
    {
      isGrounded = false;
      //controller.anim.SetBool("IsJumping" , true);
    }
    
   }

  
}
