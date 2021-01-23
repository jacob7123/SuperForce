using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    public GameObject Fire_Partical;
    public AudioClip Fire_Sound;

    public Rigidbody Bullet_Source;
    public int Throw_Y = 2;
    public int Throw_Z = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody Bullet = Instantiate(Bullet_Source, transform.position, transform.rotation);
            Bullet.velocity = transform.TransformDirection(new Vector3(0, Throw_Y, Throw_Z));// 投擲的力量
            Instantiate(Fire_Partical, transform.position, transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
        }
    }
}
