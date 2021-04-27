using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGeneration : MonoBehaviour
{
    [SerializeField] protected GameObject bullet;

    //Variables for handling attack cooldown
    //After you fire, you're put on cooldown
    [SerializeField] protected float fireCooldown;
    private float fireCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckShoot();
    }

    private void FixedUpdate()
    {
        //Update fire cooldown here
    }

    void CheckShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b =  Instantiate(bullet);
            b.transform.position = this.transform.position; 
            //Probably here is also where we assign the current direction of the player to the bullet
        }
    }

}
