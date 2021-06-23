using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected int maxHealth = 3;
    private int currentHealth;
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
}
