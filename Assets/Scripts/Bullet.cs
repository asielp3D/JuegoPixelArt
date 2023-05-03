using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rBody2D;
    public float bulletSpeed = 5;
    SFXManager sfxManager;
    // Start is called before the first frame update
    
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
    
    void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();
        rBody2D.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }   
    
   void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.layer == 7)
        {
            Enemy enemyScript = collider.gameObject.GetComponent<Enemy>();
            enemyScript.Die();
            Destroy(this.gameObject);
            sfxManager.EnemyDeath();
        }
        if(collider.gameObject.tag == "Player" || collider.gameObject.tag == "ColisionCoin"|| collider.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }

        
    }
    
}