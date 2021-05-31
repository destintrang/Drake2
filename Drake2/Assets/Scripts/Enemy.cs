using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [SerializeField] protected int maxHealth = 3;
    private int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TakeDamage ()
    {
        //Call this when you get hit by a bullet

        //Decrement health
        //If the enemy health hits 0, then the enemy dies
       currentHealth--;
       if (currentHealth <= 0) 
            KillEnemy();
    }

    public void KillEnemy()
    {
        Destroy(this.gameObject);
    }


}
