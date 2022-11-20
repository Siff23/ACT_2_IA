using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP_Action : MonoBehaviour
{
    //VELOCIDAD HACIENDO LA LISTA DE WAYPOINTS
    float speed = 5.0f;
    //PUBLICA EN EL INSPECTOR PARA ANIDAR A PETER
    public Transform target;

    private void Start()
    {
        //PARA QUE MIRE EN LOS EJES X Y Z HACIA EL TAG QUE ES WP
        transform.LookAt(new Vector3(target.position.x, transform.position.z));
    }

    private void Update()
    {
        //SE MUEVE EN EL EJE INDICADO, Z
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime)); 
    }
    // CUANDO DETECTA OTRO COLLIDER 
    private void OnTriggerEnter(Collider other)
    {
        //IRA DE UN WP AL SIGUENTE WP EN TODOS LOS EJES SI ES NECESARIO
        if (other.tag == "WayPoint") 
        {
            target = other.gameObject.GetComponent<WayPoint>().nextPoint;
            transform.LookAt(new Vector3(target.position.y, target.position.x, transform.position.z));
        }
    }
}
