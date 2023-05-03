using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool canShoot;
    public float powerUpDuration;
    float powerUpTimer = 0;

    public List<GameObject> enemiesInScreen = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ShootPowerUp();
    }

     void ShootPowerUp()
       {
        if(canShoot)
            {
            if(powerUpTimer <= powerUpDuration)
            {
                powerUpTimer+= Time.deltaTime;
            }
            else
            {
                canShoot = false;
                powerUpTimer = 0;
            }
        }
       }

}
