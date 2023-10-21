using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandler : MonoBehaviour
{
    public BoxCollider2D button; // The GameObject to activate
    public BoxCollider2D door;
    private bool canActivate = false;

    public RoomRotation roomRotation;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canActivate && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("activate");
            door.isTrigger = true;
            roomRotation.StopRoomRotation();
        }
    }

    private void OnTriggerEnter2D(Collider2D button)
    {
        if (button.CompareTag("Player")) // Adjust the tag to match your player's tag
        {
            canActivate = true;
            Debug.Log("Player entered the button's collider.");
        }
    }

    private void OnTriggerExit2D(Collider2D button)
    {
        if (button.CompareTag("Player")) // Adjust the tag to match your player's tag
        {
            canActivate = false;
            Debug.Log("Player exited the button's collider.");
        }
    }
}
