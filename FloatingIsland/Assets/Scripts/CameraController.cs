using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    // Position vars
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    // Rotation vars
    private Vector3 activePos;

    void Start()
    {
        // Setup cam positions
        pos1 = new Vector3(15, 9, -15);
        pos2 = new Vector3(-65, 9, 15);
        pos3 = new Vector3(15, 9, 65);
        // Setup start pos
        activePos = pos1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            if(activePos == pos1)
            {
                transform.position = pos2;
            }
        }

        if (Keyboard.current.dKey.isPressed)
        {
            if (activePos == pos1)
            {
                transform.position = pos3;
            }
        }
    }
}
