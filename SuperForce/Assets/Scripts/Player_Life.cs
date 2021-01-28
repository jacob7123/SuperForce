using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour
{
    public static int Life_Num = 10;
    public GameObject Game_Fail_UI;
    public GameObject Game_Pass_UI;
    // Start is called before the first frame update
    void Start()
    {
        Life_Num = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life_Num <= 0)
        {
            Game_Fail_UI.SetActive(true);
            //SceneManager.LoadScene("Game_Start");
            StartCoroutine("GamePass");
        }
        if(Life_Num > 0 && Gem_Player_Get_Count.Gem_Get_Total == 4)
        {
            Game_Pass_UI.SetActive(true);
            //SceneManager.LoadScene("Game_Start");
            StartCoroutine("GamePass");
        }
    }
    IEnumerator GamePass()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game_Start");
    }
}
