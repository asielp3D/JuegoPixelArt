using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip enemyDeath;
    public AudioClip playerDeath;
    public AudioClip pickObject;
    private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    
    public void EnemyDeath()
    {
        source.PlayOneShot(enemyDeath);
    }

    public void PlayerDeath()
    {
        source.PlayOneShot(playerDeath);
    }

    public void PickObject()
    {
        source.PlayOneShot(pickObject);
    }
}
