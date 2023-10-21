using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] public float ballSpeed;
    private BoxCollider2D ballCollider;
    private Rigidbody2D rb;
    private bool grounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += movement * ballSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D ballCollider)
    {
        if (ballCollider.CompareTag("RotationTrigger")) // Adjust the tag to match your player's tag
        {
            
        }
    }

}
