using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PARA QUE PETER VAYA ENLAZADO SIEMPRE AL TEXT INDISTINTAMENTE DEL NIVEL//
    public static PlayerController Instance { get; private set; }
    void Awake() { Instance = this; }

    //PODER ACCEDER A EL DESDE CUALQUIER PARTE DE LOS SCRIPTS Y QUE APAREZCA EN EL INSPECTOR PARA INDICAR LA VIDA MAXIMA//
    public int healthmax;
    // SI SOLO PONEMOS INT ES PARA QUE NO SEA PUBLICO//
    public int health;

    public float playerSpeed = 8; // VELOCIDAD DEL PLAYER
    public float gravityForce = 5; // LA GRAVEDAD QUE NO TIENE
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); //EL CONTROL CONTROL DEL PLAYES ES CON EL COMPONENTE CHARACTER CONTROLLER
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //MOVIMIENTO HORIZONTAL 
        float z = Input.GetAxis("Vertical"); //MOVIMIENTO VERTICAL
        Vector3 movement = transform.right * x + transform.forward * z + transform.up * 0;
        movement *= Time.deltaTime * playerSpeed; //MULTIPLICA POR EL TIMPO Y LA VELOCIDAD = AL MOVIMIENTO
        movement.y /= playerSpeed; //EL MOVIMIENTO EN Y DIVIDE LA VELOCIDAD DEL PLAYER

        Debug.Log("x" + x + "y" + z); //INDIQUE SI FUNCIONA EL MOVIMIENTO

        controller.Move(movement); //INDICAS EL NUMERO DE LA VARIABLE DEL MOVIMIENTO DEL PLAYER
    }
}
