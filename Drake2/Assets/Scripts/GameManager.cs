using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        foreach (Unit u in FindObjectsOfType<Unit>())
        {
            u.OnGameOver();
        }
        WaveManager.instance.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
