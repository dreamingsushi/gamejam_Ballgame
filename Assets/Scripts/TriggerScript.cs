using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public BoxCollider2D trigger;

    public RoomRotation roomRotation;
    public bool startRotate = false;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            startRotate = true;
            roomRotation.levelComplete = false;
        }
    }
}
