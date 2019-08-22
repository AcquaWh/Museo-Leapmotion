using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamecube : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI message;

    void OnTriggerStay(Collider other){
        message.text = "Consola Nintendo GameCube: Reconocido por tener forma de cubo.";
    }
    private void OnTriggerExit(Collider other){
        message.text = "";
    }
}
