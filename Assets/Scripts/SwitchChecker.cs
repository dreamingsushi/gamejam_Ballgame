using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChecker : MonoBehaviour
{
    public List<GameObject> switches;

    private SwitchLogic switchLogic;

    private bool AllBooleanCheck = false;
    private int booleanCheck = 0;

    public RoomRotation roomRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (booleanCheck >= 4)
        {
            roomRotation.StopRoomRotation();
        }
    }

    public void GetValue(int value)
    {
        booleanCheck += value;
        Debug.Log(booleanCheck.ToString());
    }
}