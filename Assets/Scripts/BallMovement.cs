using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] public float ballSpeed = 5;
    [SerializeField] private CircleCollider2D ballCollider;
    private Rigidbody2D rb;
    private bool grounded;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        ballCollider = GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += movement * ballSpeed * Time.deltaTime;
    }
}
