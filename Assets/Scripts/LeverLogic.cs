using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLogic : MonoBehaviour
{
    public bool isActivated = false;

    private void OnMouseDown()
    {
        if (!isActivated)
        {
            ActivateLever();
        }
    }

    public void ActivateLever()
    {
        isActivated = true;
        Debug.Log("Im clicked");
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
