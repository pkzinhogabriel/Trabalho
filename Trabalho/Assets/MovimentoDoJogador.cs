using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float velocidadeDoJogador =3.0f ;
    // Start is called before the first frame update
    
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
       
        rigidbody2d.velocity = new Vector2(horizontal * velocidadeDoJogador, rigidbody2d.velocity.y);
    }
    
}
