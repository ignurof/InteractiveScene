using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Controls everything related to interacting with the islands

public class IslandController : MonoBehaviour
{
    // Islands
    public IslandSO islandSO;
    private GameObject island1;
    private GameObject island2;
    private GameObject island3;
    public Vector3 spawnPos1 = new Vector3(0, 0, 0);
    public Vector3 spawnPos2 = new Vector3(0, 0, 0);
    public Vector3 spawnPos3 = new Vector3(0, 0, 0);

    // We need somewhere to store input values from mouse
    private Vector2 delta;

    // Handle current selection
    [Header("Selected")]
    [SerializeField]
    private GameObject activeIsland;


    // Rotate current island
#pragma warning disable IDE0051 // Remove unused private members
    Vector3 currentEulerAngles;
#pragma warning restore IDE0051 // Remove unused private members

    // Setup CallbackContext for EventSystem
    public void Controls(InputAction.CallbackContext context)
    {
        delta = context.ReadValue<Vector2>();
    }

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
        //apply the Quaternion.eulerAngles change to the gameObject
        activeIsland.transform.Rotate(0, delta.x, 0);
    }
}
