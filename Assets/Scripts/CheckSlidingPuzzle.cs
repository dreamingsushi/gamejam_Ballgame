using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CheckSlidingPuzzle : MonoBehaviour
{
    private OpenSlidingPuzzle slidingPuzzle;
    

    public bool IsPressed = false;

    public GameObject OpenSlidingPuzzleGameObject;
    public GameObject CurrentPlayerLocation;

    private RoomRotation roomRotation;
    public GameObject TheRoom;

    // Start is called before the first frame update
    void Start()
    {
        slidingPuzzle = GetComponent<OpenSlidingPuzzle>();
        OpenSlidingPuzzleGameObject.SetActive(false);
        roomRotation = TheRoom.GetComponent<RoomRotation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetBooleanValue(int booleanValue)
    {
        if (booleanValue >= 1)
        {
            Debug.Log("Delivered");
            IsPressed = true;
            if (IsPressed) 
            {
                roomRotation.stopRotation = true;
                OpenSlidingPuzzleGameObject.SetActive(true);
                CurrentPlayerLocation.SetActive(false);
            }
        }
    }
}
