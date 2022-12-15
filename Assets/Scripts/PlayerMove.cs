using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Velocidades
    public float runSpeed = 2;
    public float jumpSpeed = 3;

    //Ajustes de salto
    public bool betterJump = true;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;

    //Cambios de animacion
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }



    void FixedUpdate()
    {
        //Movimiento
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        } else if (Input.GetKey("a") || Input.GetKey("left")) {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        } else {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }
        
        //Salto
        if (Input.GetKey("space") && CheckGround.isGrounded) {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        
        if (CheckGround.isGrounded == false) {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }

        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }

        //Salto mejorado
        if (betterJump) {
            if (rb2D.velocity.y < 0) {
                rb2D.velocity += Vector2.up*Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            } 
            if (rb2D.velocity.y > 0 && !Input.GetKey("space")) {
                rb2D.velocity += Vector2.up*Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }
    }
}
