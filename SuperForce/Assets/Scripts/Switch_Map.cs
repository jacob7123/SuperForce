using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Map : MonoBehaviour
{
    public GameObject Map_Cam;
    public GameObject Life_Gem_UI;
    public AudioClip Sound;
    private bool KeyState = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<AudioSource>().PlayOneShot(Sound);
            if(KeyState == false)
            {
                Map_Cam.SetActive(true);
                Life_Gem_UI.SetActive(false);
                KeyState = true;
            }
            else
            {
                Map_Cam.SetActive(false);
                Life_Gem_UI.SetActive(true);
                KeyState = false;
            }
        }
    }
}
