using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
    //Variables de Joystick
    private float horizontalMove = 0f;

    public Joystick joystick;


    //Velocidades
    public float runSpeed = 1.25f;
    public float jumpSpeed = 3;

    //Velocidades del Joystick
    private float runSpeedHorizontal = 2;

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

    private void Update()
    {
        //Animaciones del movimiento
        if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        }
        else if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }

        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }

    }

    void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;

    }

    public void Jump()
    {
        //Salto
        if (CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }

        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }
        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
    }
}
