using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public GameInputManager InputManager;
    public Rigidbody playerBody;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(InputManager.Movement.x > 0)
        {
            //move right
            playerBody.velocity = new Vector3(speed,0,0);
        }
        if (InputManager.Movement.x < 0)
        {
            //move left
            playerBody.velocity = new Vector3(-speed, 0, 0);
        }
        if ( InputManager.Movement.x == 0)
        {
            //stop
            playerBody.velocity = new Vector3(0, 0, 0);
        }
    }
}
