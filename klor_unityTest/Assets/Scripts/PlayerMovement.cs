using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (animator != null)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

            animator.SetTrigger("IdleCycle");
        }

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        } else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    public void ResetAnimation()
    {
        if (animator != null)
        {
            animator.SetFloat("Speed", 0f);
        }
    }
}