using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected GameObject deathScreen;

    private bool paused = false;
    private bool isDead = false;
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

    private void CheckForDeathInput()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void GameOver()
    {
        PauseObjects();
        WaveManager.instance.enabled = false;
        deathScreen.SetActive(true);
        isDead = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        CheckForPause();
        if(isDead)
        {
            CheckForDeathInput();
        }
    }
}
