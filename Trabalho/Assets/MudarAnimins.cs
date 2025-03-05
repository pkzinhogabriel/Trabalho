using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarAnimins : MonoBehaviour
{
    public Animator controlador;
    // Start is called before the first frame update
    void Start()
    {
        controlador = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.W))
        {
            controlador.SetTrigger("Muda");
        }
       else if (Input.GetKeyDown(KeyCode.S))
        {
            controlador.SetTrigger("Desmuda");
        }
    }
}
