using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonsManagement : MonoBehaviour
{
    public int index = 0;
    public Sprite[] sprites;

    public Image representation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseIndex(int num){
        if(index == 2) index = 0;
        else ++index;
        if(num == 1) StaticForData.skinPlayer1 = index;
        else StaticForData.skinPlayer2 = index;
    }

    public void decreaseIndex(int num){
        if(index == 0) index = 2;
        else --index;
        if(num == 1) StaticForData.skinPlayer1 = index;
        else StaticForData.skinPlayer2 = index;
    }

    public void setSprite(){
        representation.sprite = sprites[index];
    }
}
