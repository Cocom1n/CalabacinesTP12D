using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private float runSpeed=5;    //velocidad de movimiento del personaje
    private float jumpSpeed=10;   //Velocidad de salto
    Rigidbody2D rb2D;   //referencia al Rb2D del personaje
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //Obtiene el RB del player
    }

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal");
        Vector2 direccion = new Vector2(movimiento, 0);
        transform.Translate(direccion * runSpeed * Time.deltaTime);

        if(movimiento >0) //si el movimiento es positivo
        {
            spriteRenderer.flipX = true;//va a voltear al sprite del player hacia la derecha
        }
        else{//pero si es negativo
            spriteRenderer.flipX = false;//mantendra al player mirando hacia la izquierda
        }

        //salto
        if (Input.GetKey("space") && checkGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
    }
}
