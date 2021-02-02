using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateIsland : MonoBehaviour
{
    // We need somewhere to store input values
    private Vector2 delta;

    // Setup CallbackContext for EventSystem
    public void Controls(InputAction.CallbackContext context)
    {
        delta = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Island on EulerAngles.x based on delta.x values
        transform.Rotate(0, delta.x, 0);
    }
}
