using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Start_Bottom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play_Fun()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit_Fun()
    {
        Application.Quit();
    }
}
