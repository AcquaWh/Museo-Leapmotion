using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Duck : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI message;

    void OnTriggerStay(Collider other){
        message.text = "Duck Hunt: Famoso juego de Nintendo hace muchos años atrás.";
    }
    private void OnTriggerExit(Collider other){
        message.text = "";
    }
}
