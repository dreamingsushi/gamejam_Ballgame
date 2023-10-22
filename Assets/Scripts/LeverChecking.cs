using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverChecking : MonoBehaviour
{
    public List<GameObject> levers;

    private LeverLogic leverLogic;
    // This is used to access the class

    private bool AllBooleanCheck = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in levers) 
        {
            leverLogic = obj.GetComponent<LeverLogic>();
            // This is how you access the class in the existing object that has this class
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!leverLogic.isActivated)
        {
            //Nothing Happened
        }
        else if (leverLogic.isActivated)
        {
            AllBooleanCheck = true;
        }

        if (AllBooleanCheck)
        {
            Debug.Log("YOU WIN BOIIIII, JOSH IS GAY");
        }
    }


}
