using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PARA QUE PETER VAYA ENLAZADO SIEMPRE AL TEXT INDISTINTAMENTE DEL NIVEL
    public static PlayerController Instance { get; private set; }
    void Awake() { Instance = this; }

    //PODER ACCEDER A EL DESDE CUALQUIER PARTE DE LOS SCRIPTS Y QUE APAREZCA EN EL INSPECTOR PARA INDICAR LA VIDA MAX
    public int healthmax;
    // SI SOLO PONEMOS INT ES PARA QUE NO SEA PUBLICO
    public int health;

    // PONER ANIMACIONES//
    Animator anim;

    public float playerSpeed = 8; //VELOCIDAD DEL PLAYER
    public float gravityForce = 5; //LA GRAVEDAD QUE NO TIENE
    private CharacterController controller;

    void Start()
    {
        //EL CONTROL CONTROL DEL PLAYES ES CON EL COMPONENTE CHARACTER CONTROLLER
        controller = GetComponent<CharacterController>();

        // CUANDO COMIENCE EL JUEGO, TIENE LA VIDA MAXIMA//
        health = healthmax;

        //INDICAR ANIMACIONES//
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //MOVIMIENTO HORIZONTAL 
        float z = Input.GetAxis("Vertical"); //MOVIMIENTO VERTICAL

        //EL MOVEMENT ES LO MISMO QUE LOS EJES
        Vector3 movement = transform.right * x + transform.forward * z + transform.up * 0;
        movement *= Time.deltaTime * playerSpeed; //MULTIPLICA POR EL TIMPO Y LA VELOCIDAD = AL MOVIMIENTO
        movement.y /= playerSpeed; //EL MOVIMIENTO EN Y DIVIDE LA VELOCIDAD DEL PETER
        movement.y -= gravityForce * Time.deltaTime; //AÑADE GRAVEDAD AL PETER

        Debug.Log("x" + x + "y" + z); //INDIQUE SI FUNCIONA EL MOVIMIENTO

        //INDICAS EL NUMERO DE LA VARIABLE DEL MOVIMIENTO DEL PETER
        controller.Move(movement);
    }

    //// CUANDO HACER LAS ANIMACIONES//SIEMPRE VALORES BAJOS//
    //void Animate()
    //{
        
    //    if (Mathf.Abs(rbody.velocity.x) > 3.0f)
    //    {
    //        anim.Play("Walk");
    //    }
    //    else
    //    {
    //        anim.Play("Idle");
    //    }
    //}
}

