using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI message;

    void OnTriggerStay(Collider other){
        message.text = "Nintendo Nes Controller: Este control se usaba para jugar a el Nintendo Nes en sus infancias.";
    }
    private void OnTriggerExit(Collider other){
        message.text = "";
    }
}
