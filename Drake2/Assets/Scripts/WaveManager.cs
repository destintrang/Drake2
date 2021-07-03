using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    //Singleton
    public static WaveManager instance;
    private void Awake()
    {
        instance = this;
    }

    private float Xbound = 30;
    private float Ybound = 15;
    private int ActiveEnemies = 0;
    private int MaxEnemies = 2;
    [SerializeField] protected Enemy e;

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
        if(ActiveEnemies < MaxEnemies)
        {
            spawn();
        }
    }

    void spawn()
    {
        Instantiate(e, GetRandomPosition(), Quaternion.identity);
        ActiveEnemies++;
    }

    Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-Xbound, Xbound), Random.Range(-Ybound, Ybound), 0);
    }

    public void OnEnemyDeath()
    {
        ActiveEnemies--;
    }
}
