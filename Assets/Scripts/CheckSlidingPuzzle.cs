using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSlidingPuzzle : MonoBehaviour
{
    private OpenSlidingPuzzle slidingPuzzle;

    public bool IsPressed = false;

    public GameObject OpenSlidingPuzzleGameObject;
    public GameObject CurrentPlayerLocation;

    // Start is called before the first frame update
    void Start()
    {
        //slidingPuzzle = GetComponent<OpenSlidingPuzzle>();
        OpenSlidingPuzzleGameObject.SetActive(false);

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
                OpenSlidingPuzzleGameObject.SetActive(true);
                Camera.main.transform.parent = null;
                CurrentPlayerLocation.SetActive(false);
            }
        }
    }
}
