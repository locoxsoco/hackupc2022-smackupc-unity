using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class CEscudoIzq : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
 
public bool buttonPressed;
public GameObject go;
 
public void OnPointerDown(PointerEventData eventData){
     buttonPressed = true;
     //go.Bloquear();
}
 
public void OnPointerUp(PointerEventData eventData){
    buttonPressed = false;
}
}
