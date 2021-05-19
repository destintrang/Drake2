using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    //Singleton
    public static BulletManager instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] protected GameObject projectile;

    private List<GameObject> pool = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToPool(GameObject p)
    {
        p.SetActive(false);
        pool.Add(p);
    }

    public GameObject RequestBullet()
    {
        if(pool.Count == 0)
        {
            return Instantiate(projectile);
        }
        else 
        {
            GameObject p = pool[0];
            pool.Remove(p);
            p.SetActive(true);
            return p;
        }

    }
}
