using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public int num_player;
    private int num_skin = 0;
    public AnimatorOverrideController red_controller;
    //public AnimatorOverrideController red_idle;
    public AnimatorOverrideController blue_controller;
    //public AnimatorOverrideController blue_idle;    
    // Start is called before the first frame update
    void Start()
    {
        if(num_player == 1) num_skin = StaticForData.skinPlayer1;
        else num_skin = StaticForData.skinPlayer2;
        if (num_skin == 1){
            GetComponent<Animator>().runtimeAnimatorController = red_controller as RuntimeAnimatorController;
            //GetComponent<Animator>().runtimeAnimatorController = red_golpe as RuntimeAnimatorController;        
        } else if (num_skin == 2){
            GetComponent<Animator>().runtimeAnimatorController = blue_controller as RuntimeAnimatorController;
            //GetComponent<Animator>().runtimeAnimatorController = blue_golpe as RuntimeAnimatorController;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
