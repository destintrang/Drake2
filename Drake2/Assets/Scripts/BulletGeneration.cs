using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGeneration : MonoBehaviour
{
    [SerializeField] protected GameObject bullet;

    //Variables for handling attack cooldown
    //After you fire, you're put on cooldown
    [SerializeField] protected int fireCooldown;
    private float fireCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        fireCounter++;
        if (fireCounter < fireCooldown)
            return;
        CheckShoot();
        //Update fire cooldown here
    }

    void CheckShoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject b =  BulletManager.instance.RequestBullet();
            b.transform.position = this.transform.position;
            //Probably here is also where we assign the current direction of the player to the bullet
            PlayerMovement.Direction d = GetComponent<PlayerMovement>().GetCurrentDirection();
            b.GetComponent<BulletMovement>().SetDirection(d);
            fireCounter = 0;
            AudioManager.instance.PlaySoundEffect("Shoot");
        }
    }

}
