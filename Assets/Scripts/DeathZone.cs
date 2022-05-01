using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathZone : MonoBehaviour
{

    public int value;
    public TextMeshProUGUI winner;
    public Canvas actualCanvas;
    public Canvas finalCanvas;
    private void OnTriggerEnter2D(Collider2D other) {
        /*if (collision.collider.CompareTag("Player")){
            ForceAdd2D Square1 = collision.collider.GetComponent<ForceAdd2D>();
            ForcePlayer2 Square2 = collision.collider.GetComponent<ForcePlayer2>();
        //}
        if (Square1 != null){
            Square1.Die();
        }
        else Square2.Die();*/
        Destroy(other.gameObject);
        if(value == 1) winner.text = "Player 2";
        else winner.text = "Player 1";
        actualCanvas.gameObject.SetActive(false);
        finalCanvas.gameObject.SetActive(true);
    }
}
