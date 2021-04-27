using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    //Direction the bullet goes
    private Vector3 bulletDirection = new Vector3(0, 0.25f, 0);


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
        transform.position = transform.position + bulletDirection;
    }


    //We call this when we create the bullet to set its direction
    public void SetDirection (PlayerMovement.Direction direction)
    {
        //Change bulletDirection
    }

}
