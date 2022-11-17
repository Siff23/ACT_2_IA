using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartBar : MonoBehaviour
{
    public Image heartBar;

    void Update()
    {
        heartBar.fillAmount = (float)PlayerController.Instance.health / (float)PlayerController.Instance.healthmax;
    }
}
