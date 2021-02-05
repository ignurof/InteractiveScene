using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    // Position vars
    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 pos3;
    private Vector3 posHolder;
    // Rotation vars
    private Quaternion rot1;
    private Quaternion rot2;
    private Quaternion rot3;

    // Smooth movement
    private float speed = 40f;
    private bool canMove;
    private bool isMoving;

    // Current selection
    //private Vector3 activePos;
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
        //activePos = pos1;
        island = 1;
        transform.position = pos1;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        // Move smoothly towards position
        if (canMove)
        {
            isMoving = true;
            transform.position = Vector3.MoveTowards(transform.position, posHolder, step);
            if (transform.position == posHolder)
            {
                canMove = false;
                isMoving = false;

                if (posHolder == pos1)
                    transform.rotation = rot1;
                else if (posHolder == pos2)
                    transform.rotation = rot2;
                else if (posHolder == pos3)
                    transform.rotation = rot3;
            }
        }

        if (Keyboard.current.aKey.wasPressedThisFrame && !isMoving)
        {
            canMove = true;
            if(transform.position == pos1)
            {
                //transform.position = pos2;
                //transform.rotation = rot2;
                posHolder = pos2;
                island = 2;
            }
            else if (transform.position == pos3)
            {
                //transform.position = pos1;
                //transform.rotation = rot1;
                posHolder = pos1;
                island = 1;
            }
        }

        if (Keyboard.current.dKey.wasPressedThisFrame && !isMoving)
        {
            canMove = true;
            if (transform.position == pos1)
            {
                //transform.position = pos3;
                //transform.rotation = rot3;
                posHolder = pos3;
                island = 3;
            }
            else if (transform.position == pos2)
            {
                //transform.position = pos1;
                //transform.rotation = rot1;
                posHolder = pos1;
                island = 1;
            }
        }
    }
}
