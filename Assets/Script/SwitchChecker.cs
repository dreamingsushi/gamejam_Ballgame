using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChecker : MonoBehaviour
{
    public List<GameObject> switches;

    private SwitchLogic switchLogic;

    private bool AllBooleanCheck = false;
    private int booleanCheck = 0;

    // Start is called before the first frame update
    void Start()
    {
        //foreach (GameObject obj in switches) 
        //{
        //    switchLogic = obj.GetComponent<SwitchLogic>();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (!switchLogic.isActivated)
        //{

        //}
        //else if (switchLogic.isActivated) 
        //{
        //    AllBooleanCheck = true;
        //}

        if (booleanCheck >= 4)
        {
            Debug.Log("Cleared");
        }
    }

    public void GetValue(int value)
    {
        booleanCheck += value;
        Debug.Log(booleanCheck.ToString());
    }
}
