using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] protected int maxHealth = 3;
    protected int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage()
    {
        //Call this when you get hit by a bullet

        //Decrement health
        //If the enemy health hits 0, then the enemy dies
        currentHealth--;
        if (currentHealth <= 0)
            Death();
    }

    public virtual void Death()
    {

    }
}
