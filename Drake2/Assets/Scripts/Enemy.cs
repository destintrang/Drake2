using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : Unit
{
    [SerializeField] protected int score = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void Death()
    {
        Player.instance.incrementScore(score);
        Destroy(this.gameObject);
        WaveManager.instance.OnEnemyDeath();
    }


}
