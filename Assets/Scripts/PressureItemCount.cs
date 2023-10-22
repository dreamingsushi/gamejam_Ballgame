using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureItemCount : MonoBehaviour
{
    public static PressureItemCount Instance;  // Singleton pattern.

    private int[] pressurePlateCounts;  // An array to store counts for each pressure plate.
    public GameObject door;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            pressurePlateCounts = new int[4]; // Create an array to store counts for 4 pressure plates.
        }
        else
        {
            door.SetActive(true);
        }
    }

    public void UpdateDoorState(int pressurePlateID, int count)
    {
        pressurePlateCounts[pressurePlateID] = count;

        // Check if all pressure plates have a count of 1 or more.
        bool shouldOpenDoor = true;
        foreach (int plateCount in pressurePlateCounts)
        {
            if (plateCount < 1)
            {
                shouldOpenDoor = false;
                break;
            }
        }
        door.SetActive(!shouldOpenDoor);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
