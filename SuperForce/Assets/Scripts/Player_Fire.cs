using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Fire_Partical;
    public AudioClip Fire_Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            Instantiate(Fire_Partical, transform.position, transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
        }
    }
}
