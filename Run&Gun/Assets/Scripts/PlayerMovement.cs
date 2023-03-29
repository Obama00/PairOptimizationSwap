using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 20;
    private Rigidbody2D rb;
    private float moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        rb.freezeRotation = true;
    }


    void Update()
    {
        moveDirection = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.x);
        rb.velocity = new Vector2( moveSpeed, rb.velocity.x);
    }
}
