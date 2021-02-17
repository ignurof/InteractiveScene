using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public IslandController iC;

    // Position vars
    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 pos3;
    private Vector3 posHolder;

    // Smooth movement
    private float speed = 80f;
    private bool canMove;
    private bool isMoving;

    // Current selection
    public int island; // 1, 2, 3

    // Cooldown
    private bool cd;

    void Start()
    {
        // Setup cam positions
        pos1 = new Vector3(85, 70, -70);
        pos2 = new Vector3(-215, 80, -30);
        pos3 = new Vector3(25, -10, 200);
        // Setup start pos
        island = 1;
        transform.position = pos1;

        cd = true;
    }

    // Smoothly rotate the camera based on target position
    void SmoothLookAt(Transform myTransform)
    {
        float step = speed * Time.deltaTime;

        Vector3 lookDirection = myTransform.transform.position - transform.position;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 2f * Time.deltaTime);

        // Move
        transform.position = Vector3.MoveTowards(transform.position, posHolder, step);

        // Reset values on reached destination
        if (transform.position == posHolder && cd)
        {
            cd = false;
            StartCoroutine(CooldownTimer());
        }
    }

    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(1f);
        canMove = false;
        isMoving = false;
        cd = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Move smoothly towards position
        if (canMove)
        {
            isMoving = true;

            // Rotate based on active target
            switch (island)
            {
                case 1:
                    SmoothLookAt(iC.island1.transform);
                    break;
                case 2:
                    SmoothLookAt(iC.island2.transform);
                    break;
                case 3:
                    SmoothLookAt(iC.island3.transform);
                    break;
            }  
        }

        // Check for A keyboard input
        if (Input.GetKeyDown(KeyCode.A) && !isMoving && !canMove)
        {
            canMove = true;

            if (transform.position == pos1)
            {
                posHolder = pos2;
                island = 2;
            }
            else if (transform.position == pos3)
            {
                posHolder = pos1;
                island = 1;
            }
        }

        // Check for D keyboard input
        if (Input.GetKeyDown(KeyCode.D) && !isMoving && !canMove)
        {
            canMove = true;
            if (transform.position == pos1)
            {
                posHolder = pos3;
                island = 3;
            }
            else if (transform.position == pos2)
            {
                posHolder = pos1;
                island = 1;
            }
        }
    }
}
