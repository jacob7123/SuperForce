using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Healthpack : MonoBehaviour
{
    public AudioClip Get_Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(Player_Life.Life_Num < 10)
                Player_Life.Life_Num++;
            //print(Gem_Player_Get_Count.Gem_Get_Total);
            GetComponent<AudioSource>().PlayOneShot(Get_Sound);
            Destroy(gameObject, 0.8f);
        }
    } 
}
