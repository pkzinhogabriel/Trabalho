using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float velocidadeDoJogador =2.0f ;
    public float jumpForce = 10.0f;
    public Transform GroundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;
    public float moveInput;
    // Start is called before the first frame update
    
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, groundLayer);
        if(Input.GetButtonDown("Jump"))
        {
            if(isGrounded)
            {
                rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x,jumpForce);
            }
        }
        float horizontal = Input.GetAxis("Horizontal");
       
        rigidbody2d.velocity = new Vector2(horizontal * velocidadeDoJogador, rigidbody2d.velocity.y);
    }
   
   
}
