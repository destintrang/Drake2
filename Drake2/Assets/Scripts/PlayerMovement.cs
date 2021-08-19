using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] protected float speed = 0.1f;
    [SerializeField] protected float baseSpeed = 0.1f;
    [SerializeField] protected int rollCooldown;
    private float rollCounter = 0;

    public enum Direction { UP, DOWN, LEFT, RIGHT };
    public Direction currentDirection = Direction.UP;
    Direction lastDirection;
    private bool rolling = false;

    const KeyCode UP = KeyCode.W;
    const KeyCode DOWN = KeyCode.S;
    const KeyCode LEFT = KeyCode.A;
    const KeyCode RIGHT = KeyCode.D;

    // Start is called before the first frame update
    void Start()
    {
        rollCounter = rollCooldown;
        speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        CheckRoll();
        if (rolling) return;
        UpdateDirection();
    }

    private void FixedUpdate()
    {
        rollCounter++;
        
        //there should be a conditional if/else here that changes the move variable based on the direction we're moving
        if (currentDirection == Direction.UP)
        {
            transform.position = transform.position + new Vector3(0, speed, 0);
        }
        else if (currentDirection == Direction.DOWN)
        {
            transform.position = transform.position + new Vector3(0, -speed, 0);
        }
        else if (currentDirection == Direction.LEFT)
        {
            transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        else if (currentDirection == Direction.RIGHT)
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }
    }

    //This is called every frame to see the player input
    private void UpdateDirection()
    {
        if (Input.GetKeyDown(KeyCode.W) && currentDirection != Direction.DOWN)
        {
            currentDirection = Direction.UP;
        }
        else if (Input.GetKeyDown(KeyCode.S) && currentDirection != Direction.UP)
            currentDirection = Direction.DOWN;
        else if (Input.GetKeyDown(KeyCode.A) && currentDirection != Direction.RIGHT)
            currentDirection = Direction.LEFT;
        else if (Input.GetKeyDown(KeyCode.D) && currentDirection != Direction.LEFT)
            currentDirection = Direction.RIGHT;

        //These all return a bool
        //Input.GetButton checks if the button is pressed
        //Input.GetButtonDown checks the frame that its pressed down
        //Input.GetButtonUp checks the frame its released

    }

    public Direction GetCurrentDirection()
    {
        if(!rolling)
        {
            return currentDirection;
        }
        else
        {
            if (currentDirection == Direction.UP) return Direction.DOWN;
            else if (currentDirection == Direction.DOWN) return Direction.UP;
            else if (currentDirection == Direction.LEFT) return Direction.RIGHT;
            else if (currentDirection == Direction.RIGHT) return Direction.LEFT;
            else return currentDirection;
        }
    }

    private void CheckRoll()
    {
        if (rollCounter < rollCooldown) return;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(Roll());
            Debug.Log("roll");
            rollCounter = 0;
        }
    }

    IEnumerator Roll ()
    {

        int counter = 0;
        int rollDuration = 20;
        rolling = true;
        speed *= 2;
        while (counter < rollDuration)
        {
            counter++;
            yield return new WaitForFixedUpdate();
        }
        speed = baseSpeed;
        rolling = false;
    }

}
