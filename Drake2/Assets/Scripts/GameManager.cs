using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool paused = false;
    //Singleton
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void PauseObjects()
    {
        foreach(PausableObject p in FindObjectsOfType<PausableObject>())
        {
            p.PauseObject();
        }
    }
    private void UnpauseObjects()
    {
        foreach (PausableObject p in FindObjectsOfType<PausableObject>())
        {
            p.UnpauseObject();
        }
    }

    private void CheckForPause()
    {
        if (Input.GetKeyDown(KeyCode.P) )
        {
            if (paused)
            {
                UnpauseObjects();
                paused = false;
            }
            else
            {
                PauseObjects();
                paused = true;
            }      
        }
    }

    public void GameOver()
    {
        PauseObjects();
        WaveManager.instance.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        CheckForPause();
    }
}
