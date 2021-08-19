using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goombah : MonoBehaviour
{
    Vector3 targetDestination = new Vector3 (0,0,-1);
    Vector3 startingPosition = new Vector3();
    [SerializeField] protected float speed = 10f;

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
        if (targetDestination == new Vector3 (0,0,-1))
        {
            //this is where we begin a new cycle
            startingPosition = this.transform.position;
            targetDestination = GetTargetLocation();
        }
        else
        {
            float percentageTravelled = (this.transform.position - startingPosition).magnitude / (targetDestination - startingPosition).magnitude;
            float reduceSpeed = Mathf.Lerp(speed, 3f, percentageTravelled);
            transform.position = Vector3.MoveTowards(transform.position, targetDestination, reduceSpeed * Time.deltaTime);
        }

        if(this.transform.position == targetDestination)
        {
            targetDestination = new Vector3(0, 0, -1);
        }
    }

    Vector3 GetTargetLocation()
    {
        Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 difference = playerPosition - this.transform.position;
        return this.transform.position + difference * 2f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        startingPosition = this.transform.position;
        targetDestination = GetTargetLocation();
    }
}
