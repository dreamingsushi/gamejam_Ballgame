using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandler : MonoBehaviour
{
    public BoxCollider2D button; // The GameObject to activate
    private bool canActivate = false;
    public RoomRotation roomRotation;
    public AudioSource clickSound;
    

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canActivate && Input.GetKeyDown(KeyCode.E))
        {
            roomRotation.StopRoomRotation();
            clickSound.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D button)
    {
        if (button.CompareTag("Player")) // Adjust the tag to match your player's tag
        {
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D button)
    {
        if (button.CompareTag("Player")) // Adjust the tag to match your player's tag
        {
            canActivate = false;
        }
    }
}
