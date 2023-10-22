using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public BoxCollider2D trigger;
    private RoomRotation roomRotation;
    public bool startRotate;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startRotate)
        {
            roomRotation.startRoomRotation();
        }
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            Debug.Log("Trigger object is null.");
            startRotate = true;
        }
        else
        {
            
        }
    }
}
