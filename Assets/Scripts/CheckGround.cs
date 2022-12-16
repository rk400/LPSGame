using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
   public static bool isGrounded;

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.CompareTag("Suelo"))
            isGrounded = true;
   }

   private void OnTriggerExit2D(Collider2D collision)
   {
        if(collision.CompareTag("Suelo"))
            isGrounded = false;
        Debug.Log("Estoy saltando y soy puto");
   }
}
