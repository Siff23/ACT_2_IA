using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseSens = 100f; //SENSIBILIDAD DEL RATON
    private float yRotation = 0f; //ROTACION DE LA CAMARA
    public PlayerController player; //REFERENCIA DEL PLAYER

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //BLOQUEAR EL RATON
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; //MOVIMIENTO EN HORIZONTAL
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime; //MOVIMIENTO EN VERTICAL

        //ROTACION EN Y 
        yRotation -= mouseY;

        //LIMITES DE CAMARA EN EJE Y
        if (yRotation >= 90)
        {
            yRotation = 90;
        }
        if (yRotation <= -90)
        {
            yRotation = -90;
        }

        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(yRotation, 0, 0), 1);
        // ROTACION EN X
        player.transform.Rotate(Vector3.up * mouseX);
    }

}
