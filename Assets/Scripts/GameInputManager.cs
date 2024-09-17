using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInputManager : MonoBehaviour
{
    public Vector2 Movement;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnMove(InputValue value)
    {
        Movement = value.Get<Vector2>();
    }
}
