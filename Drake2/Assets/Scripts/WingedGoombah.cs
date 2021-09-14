using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingedGoombah : MonoBehaviour
{
    Vector3 targetDestination = new Vector3(0, 0, -1);
    int side = -1;
    [SerializeField] protected float speed = 10f;

    private void FixedUpdate()
    {
        if (targetDestination == new Vector3(0, 0, -1))
        {
            targetDestination = GetTargetLocation();
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetDestination, speed * Time.deltaTime);
        }

        if (this.transform.position == targetDestination)
        {
            targetDestination = new Vector3(0, 0, -1);
        }
    }

    Vector3 GetTargetLocation()
    {
        if(side == -1)
        {
            side = 1;
        }    
        else
        {
            side = -1;
        }
        Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 difference = playerPosition - this.transform.position * 0.25f;
        difference = Quaternion.AngleAxis(30 * side, Vector3.up) * difference;
        Vector3 target = this.transform.position + difference;
        return target;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //startingPosition = this.transform.position;
        targetDestination = GetTargetLocation();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
