using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePlayer2 : MonoBehaviour
{
   
    Rigidbody2D myRB;
    public GameObject boton1;
    public Animator animator;
    public bool esta_bloqueado = false;
    public void Bloquear(){
        esta_bloqueado = true;
        myRB.mass = 5;
    }
    public void no_bloqueado(){
        esta_bloqueado = false;
        myRB.mass = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
      myRB = this.GetComponent<Rigidbody2D> (); 
    }
    public void AddForceUp(){
        animator.SetTrigger("punchin");
        float rand = Random.Range(-20f,-5f);
        myRB.AddForce(new Vector2(rand,0),ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        if (esta_bloqueado) {
            if (myRB.mass >= 0) myRB.mass -= (1f * Time.deltaTime);
        }
     }
      public void Die(){
        Destroy(gameObject);
    }
}