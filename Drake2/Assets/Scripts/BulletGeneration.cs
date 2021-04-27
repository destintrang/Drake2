using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGeneration : MonoBehaviour
{
    [SerializeField] protected GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckShoot();
    }

    void CheckShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b =  Instantiate(bullet);
            b.transform.position = this.transform.position; 
        }
    }

}
