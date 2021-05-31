using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goombah : MonoBehaviour
{
    Vector3 targetDestination = new Vector3 (0,0,-1);

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
            targetDestination = GetTargetLocation();
            Debug.Log(targetDestination);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetDestination, 10f * Time.deltaTime);
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

}
