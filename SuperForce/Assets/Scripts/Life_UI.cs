using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_UI : MonoBehaviour
{
    public Image Show_Life_UI;
    public Sprite[] Sprite_Texture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player_Life.Life_Num == 10)
        {
            Show_Life_UI.sprite = Sprite_Texture[9];
        }
        else if (Player_Life.Life_Num == 9)
        {
            Show_Life_UI.sprite = Sprite_Texture[8];
        }
        else if (Player_Life.Life_Num == 8)
        {
            Show_Life_UI.sprite = Sprite_Texture[7];
        }
        else if (Player_Life.Life_Num == 7)
        {
            Show_Life_UI.sprite = Sprite_Texture[6];
        }
        else if (Player_Life.Life_Num == 6)
        {
            Show_Life_UI.sprite = Sprite_Texture[5];
        }
        else if (Player_Life.Life_Num == 5)
        {
            Show_Life_UI.sprite = Sprite_Texture[4];
        }
        else if (Player_Life.Life_Num == 4)
        {
            Show_Life_UI.sprite = Sprite_Texture[3];
        }
        else if (Player_Life.Life_Num == 3)
        {
            Show_Life_UI.sprite = Sprite_Texture[2];
        }
        else if (Player_Life.Life_Num == 2)
        {
            Show_Life_UI.sprite = Sprite_Texture[1];
        }
        else if(Player_Life.Life_Num == 1)
        {
            Show_Life_UI.sprite = Sprite_Texture[0];
        }
        else
        {
            Show_Life_UI.enabled = false;
        }
    }
}
