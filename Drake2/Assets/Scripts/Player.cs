using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    private int score = 0;

    //Singleton
    public static Player instance;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementScore(int s)
    {
        score += s;
    }

    public override void Death()
    {
        Debug.Log("you died");
        //use instance to call singletons 
        GameManager.instance.GameOver();
    }
}
