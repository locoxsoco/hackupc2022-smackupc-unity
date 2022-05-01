using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAdd2D : MonoBehaviour
{   
    
    Rigidbody2D myRB;
    public Animator animator;
    public GameObject boton1;
    bool esta_bloqueado = false;

    private Rigidbody2D Rigidbody2D;
    private Animation asdsa;

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
      //animator.SetBool("punchin", false);
    }
    public void AddForceUp(){
        Debug.Log("asdsad");
        animator.SetTrigger("punchin");
        animator.SetBool("isDead",false);
        Debug.Log("asdsaxzxzcd");

        float rand = Random.Range(5f,20f);
        myRB.AddForce(new Vector2(rand,0),ForceMode2D.Impulse);
        
       //animator.SetBool("punchin", false);
       Debug.Log("asdsaasasdsadsadd");

    }
    // Update is called once per frame
    void Update()
    {
        
        if (esta_bloqueado) {
            if (myRB.mass >= 0) myRB.mass -= (1f * Time.deltaTime);
        }
     
     void Die(){
        Destroy(gameObject);
    }

    

    void OnCollisionEnter2D(Collision2D other) {
        DeathZone pared = other.collider.GetComponent<DeathZone>();
        if (pared != null) Destroy(gameObject);
    }
}
}
