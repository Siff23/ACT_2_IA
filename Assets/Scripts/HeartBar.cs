using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartBar : MonoBehaviour
{
    //PARA PODER PONER UNA IMAGEN DESDE EL INSPECTOR
    public Image heartBar;

    void Update()
    {
        heartBar.fillAmount = (float)PlayerController.Instance.health / (float)PlayerController.Instance.healthmax;
    }
}
