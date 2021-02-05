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
    public Quaternion rot1;
    public Quaternion rot2;
    public Quaternion rot3;

    // Current selection
    private Vector3 activePos;
    public int island; // 1, 2, 3

    void Start()
    {
        // Setup cam positions
        pos1 = new Vector3(15, 9, -15);
        pos2 = new Vector3(-65, 9, -15);
        pos3 = new Vector3(15, 9, 65);
        // Cam rotations
        rot1 = Quaternion.Euler(25, -45, 0);
        rot2 = Quaternion.Euler(25, 45, 0);
        rot3 = Quaternion.Euler(25, -135, 0);
        // Setup start pos
        activePos = pos1;
        island = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            if(activePos == pos1)
            {
                transform.position = pos2;
                transform.rotation = rot2;
                activePos = pos2;
                island = 2;
            }
            else if (activePos == pos3)
            {
                transform.position = pos1;
                transform.rotation = rot1;
                activePos = pos1;
                island = 1;
            }
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            if (activePos == pos1)
            {
                transform.position = pos3;
                transform.rotation = rot3;
                activePos = pos3;
                island = 3;
            }
            else if (activePos == pos2)
            {
                transform.position = pos1;
                transform.rotation = rot1;
                activePos = pos1;
                island = 1;
            }
        }
    }
}
