using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem_UI : MonoBehaviour
{
    public Image[] Show_Gem_UI;
    public Sprite[] Sprite_Texture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gem_Player_Get_Count.Gem_Get_Total == 0)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[0];
            Show_Gem_UI[1].sprite = Sprite_Texture[0];
            Show_Gem_UI[2].sprite = Sprite_Texture[0];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        else if (Gem_Player_Get_Count.Gem_Get_Total == 1)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[0];
            Show_Gem_UI[2].sprite = Sprite_Texture[0];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        else if (Gem_Player_Get_Count.Gem_Get_Total == 2)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[1];
            Show_Gem_UI[2].sprite = Sprite_Texture[0];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        else if (Gem_Player_Get_Count.Gem_Get_Total == 3)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[1];
            Show_Gem_UI[2].sprite = Sprite_Texture[1];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        else
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[1];
            Show_Gem_UI[2].sprite = Sprite_Texture[1];
            Show_Gem_UI[3].sprite = Sprite_Texture[1];
        }
    }
}
