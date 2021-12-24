using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float direction;
    private bool right;

    //Awake is called after all objects are initialized. Called in random order.
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);

        //Flipping mechanism
        if (direction > 0 && !right)
        {
            sr.flipX = true;
            right = true;
        }
        else if (direction < 0 && right)
        {
            sr.flipX = false;
            right = false;
        }
    }
}
