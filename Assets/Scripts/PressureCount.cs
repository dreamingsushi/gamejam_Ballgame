using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureCount : MonoBehaviour
{
    public GameObject door;
    public List<GameObject> pressurecount;
    private PressurePlateBehavior pressureLogic;
    // This is used to access the class

    private bool AllBooleanCheck = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in pressurecount)
        {
            pressureLogic = obj.GetComponent<PressurePlateBehavior>();
            // This is how you access the class in the existing object that has this class
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!pressureLogic.isActivated)
        {
            //door.SetActive(true);
            //Nothing Happened
        }
        else if (pressureLogic.isActivated)
        {
            AllBooleanCheck = true;
        }

        if (AllBooleanCheck)
        {
            door.SetActive(false);
        }
    }
}
