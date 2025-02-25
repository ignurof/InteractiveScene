﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls everything related to interacting with the islands

public class IslandController : MonoBehaviour
{
    // Cam
    public GameObject cam;
    // Islands
    public IslandSO islandSO;
    public GameObject island1;
    public GameObject island2;
    public GameObject island3;
    private Vector3 spawnPos1 = new Vector3(0, 0, 0);
    private Vector3 spawnPos2 = new Vector3(-200, 60, 0);
    private Vector3 spawnPos3 = new Vector3(0, -33, 200);

    // Handle current selection
    [Header("Selected")]
    [SerializeField]
    private GameObject activeIsland;

    void Start()
    {
        // Spawn islands
        island1 = Instantiate(islandSO.islandOne, spawnPos1, Quaternion.Euler(0, 0, 0));
        island2 = Instantiate(islandSO.islandTwo, spawnPos2, Quaternion.Euler(0, 0, 0));
        island3 = Instantiate(islandSO.islandThree, spawnPos3, Quaternion.Euler(0, 0, 0));

        activeIsland = island1;
    }

    // Update is called once per frame
    void Update()
    {
        // Make sure we rotate the active island
        switch (cam.GetComponent<CameraController>().island)
        {
            case 1: activeIsland = island1;
                break;
            case 2: activeIsland = island2;
                break;
            case 3: activeIsland = island3;
                break;
        }
        // Rotate current island while holding RMB
        if(Input.GetKey(KeyCode.Mouse1))
            activeIsland.transform.Rotate(0, Input.GetAxis("Mouse X") * 2f, 0);
    }
}
