using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : PausableObject
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<Enemy>() != null)
        {
            col.gameObject.GetComponent<Enemy>().TakeDamage();
            BulletManager.instance.AddToPool(this.gameObject);
            StopAllCoroutines();
        }
    }


    IEnumerator ProjectileDuration()
    {

        float timer = 0f;

        while (timer < 5f)
        {
            timer += Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }

        BulletManager.instance.AddToPool(this.gameObject);

    }

    //We call this when we create the bullet to set its direction
    public void SetDirection(PlayerMovement.Direction direction)
    {
        StartCoroutine(ProjectileDuration());
        //Change bulletDirection
        if (direction == PlayerMovement.Direction.UP)
        {
            bulletDirection = new Vector3(0, 0.25f, 0);
        }
        else if (direction == PlayerMovement.Direction.DOWN)
        {
            bulletDirection = new Vector3(0, -0.25f, 0);
        }
        else if (direction == PlayerMovement.Direction.LEFT)
        {
            bulletDirection = new Vector3(-0.25f, 0, 0);
        }
        else if (direction == PlayerMovement.Direction.RIGHT)
        {
            bulletDirection = new Vector3(0.25f, 0, 0);
        }
    }

}
