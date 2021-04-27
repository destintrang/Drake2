using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] protected float speed = 0.1f;


    public enum Direction { UP, DOWN, LEFT, RIGHT };
    Direction currentDirection = Direction.UP;
    Direction lastDirection;


    const KeyCode UP = KeyCode.W;
    const KeyCode DOWN = KeyCode.S;
    const KeyCode LEFT = KeyCode.A;
    const KeyCode RIGHT = KeyCode.D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDirection();
    }

    private void FixedUpdate()
    {
        //Vector3 move = new Vector3(0, speed, 0);
        ////there should be a conditional if/else here that changes the move variable based on the direction we're moving
        //if(currentDirection = Direction.UP)
        //{
        //    transform.position = transform.position + move;
        //}
        
        
    }

    Vector3 ChangeDirection()
    {
        switch (currentDirection)
        {
            case Direction.UP:
                lastDirection = Direction.UP;
                return (transform.position + new Vector3(0, speed, 0));
            case Direction.DOWN:
                lastDirection = Direction.DOWN;
                return (transform.position + new Vector3(0, -speed, 0));
            case Direction.LEFT:
                lastDirection = Direction.LEFT;
                return (transform.position + new Vector3(-speed, 0, 0));
            case Direction.RIGHT:
                lastDirection = Direction.RIGHT;
                return (transform.position + new Vector3(speed, 0, 0));
        }

        return (transform.position + new Vector3(0, 1, 0));
    }

    //This is called every frame to see the player input
    private void UpdateDirection ()
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

}
