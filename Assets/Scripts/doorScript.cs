using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public BoxCollider2D doorCollider;
    [SerializeField] private BoxCollider2D invisibleCollider;
    public Transform ball;
    public Transform teleportPos;
    public RoomRotation roomRotation;
    // Start is called before the first frame update
    void Start()
    {
        doorCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roomRotation.levelComplete)
        {
            doorCollider.isTrigger = true;
            invisibleCollider.isTrigger = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D doorCollider)
    {
        if (doorCollider.CompareTag("Player")) // Adjust the tag to match your player's tag
        {
            teleportToNextLevel();
        }
    }
    private void teleportToNextLevel()
    {
        ball.position = teleportPos.position;
    }

}
