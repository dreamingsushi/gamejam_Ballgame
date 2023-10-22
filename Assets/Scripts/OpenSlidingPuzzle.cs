using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSlidingPuzzle : MonoBehaviour
{
    private CheckSlidingPuzzle checkSlidingPuzzle;
    private bool canPress = false;

    // Start is called before the first frame update
    void Start()
    {
        
        checkSlidingPuzzle = GameObject.FindWithTag("camPos").GetComponent<CheckSlidingPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canPress) 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Pressed");

                checkSlidingPuzzle.GetBooleanValue(1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.name);
            canPress = true;
        }
    }




}
